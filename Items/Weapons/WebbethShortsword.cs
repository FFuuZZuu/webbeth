using Terraria.ID;
using Terraria.ModLoader;
using Webbeth.Items.Placeable;
using static Terraria.ModLoader.ModContent;

namespace Webbeth.Items.Weapons
{
    public class WebbethShortsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Webbeth Shortsword");
            Tooltip.SetDefault("Stabby stab stab");
        }

        public override void SetDefaults()
        {
            item.value = 8000;
            item.width = 32;
            item.height = 32;
            item.useStyle = 3;
            item.useTime = 14;
            item.useAnimation = 14;
            item.UseSound = SoundID.Item1;
            item.rare = 3;

            item.damage = 19;
            item.knockBack = 3;
            item.crit = 2;
            item.melee = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            // Takes: 10 Webbeth Bars
            recipe.AddIngredient(ItemType<WebbethBar>(), 8);
            // In: Furnace
            recipe.AddTile(TileID.Furnaces);
            // To make: A webbeth broadsword
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}