using Webbeth.Items.Placeable;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace Webbeth.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class WebbethGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Webbeth Greaves");
            Tooltip.SetDefault("The ultimate spider based armor!"
                + "\nImmunity to 'Slow!'");
        }

        public override void SetDefaults()
        {
            item.width = 35;
            item.height = 35;
            item.value = 9000;
            item.rare = 3;
            item.defense = 7;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Slow] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<WebbethBar>(), 18);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}