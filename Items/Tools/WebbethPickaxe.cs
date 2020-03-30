using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Webbeth.Items.Placeable;

namespace Webbeth.Items.Tools
{
    public class WebbethPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Webbeth Pickaxe");
            Tooltip.SetDefault("Helps you get out of some sticky situation");
        }

        public override void SetDefaults()
        {
            item.value = 8000;
            item.useStyle = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 20;
            item.useTime = 20;
            item.rare = 3;
            item.width = 32;
            item.height = 32;
            item.UseSound = SoundID.Item1;
            item.damage = 15;
            item.knockBack = 2;
            item.pick = 90;
            item.crit = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<WebbethBar>(), 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}