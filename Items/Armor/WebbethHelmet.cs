using Webbeth.Items.Placeable;
using Webbeth.Buffs;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace Webbeth.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class WebbethHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Webbeth Greaves");
            Tooltip.SetDefault("The ultimate spider based armor!"
                + "\nImmunity to 'Stuck!'");
        }

        public override void SetDefaults()
        {
            item.width = 35;
            item.height = 35;
            item.value = 9000;
            item.rare = 3;
            item.defense = 7;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<WebbethBreastplate>() && legs.type == ItemType<WebbethGreaves>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(BuffType<SpiderVision>(), 3);
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffType<Stuck>()] = true;
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