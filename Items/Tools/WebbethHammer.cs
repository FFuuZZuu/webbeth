using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Webbeth.Items.Placeable;

namespace Webbeth.Items.Tools
{
    public class WebbethHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Webbeth Hammer");
        }

        public override void SetDefaults()
        {
            item.value = 8000;
            item.useStyle = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 40;
            item.useTime = 40;
            item.rare = 3;
            item.width = 30;
            item.height = 30;
            item.UseSound = SoundID.Item1;
            item.damage = 18;
            item.knockBack = 7;
            item.hammer = 60;
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