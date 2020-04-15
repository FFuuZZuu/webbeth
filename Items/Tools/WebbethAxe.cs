using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Webbeth.Items.Placeable;

namespace Webbeth.Items.Tools
{
    public class WebbethAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Webbeth Axe");
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
            item.width = 66;
            item.height = 56;
            item.UseSound = SoundID.Item1;
            item.damage = 15;
            item.knockBack = 5;
            item.axe = 24;
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