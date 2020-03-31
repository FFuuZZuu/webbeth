using Webbeth.Items.Placeable;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace Webbeth.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class WebbethBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Webbeth Breastplate");
            Tooltip.SetDefault("The ultimate spider based armor!"
                + "\nImmunity to 'Webbed!'");
        }

        public override void SetDefaults()
        {
            item.width = 35;
            item.height = 35;
            item.value = 10000;
            item.rare = 3;
            item.defense = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Webbed] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<WebbethBar>(), 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}