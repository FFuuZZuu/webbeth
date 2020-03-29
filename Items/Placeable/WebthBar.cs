using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Webth.Items.Placeable
{
    public class WebthBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Webth Bar");
        }

        public override void SetDefaults()
        {
            item.width = 1;
            item.height = 1;
            item.maxStack = 99;
            item.rare = 3;
            item.value = 1000;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 15;
            item.autoReuse = true;
            item.useTurn = true;
            item.consumable = true;
            item.createTile = TileType<Tiles.WebthBar>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            // Takes: 4 Webth Ore
            recipe.AddIngredient(ItemType<WebthOreItem>(), 4);
            // In: Any Furnace
            recipe.AddTile(TileID.Furnaces);
            // To Make: Webth Bar
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}