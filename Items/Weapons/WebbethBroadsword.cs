using Terraria.ID;
using Terraria.ModLoader;
using Webbeth.Items.Placeable;
using static Terraria.ModLoader.ModContent;

namespace Webbeth.Items.Weapons
{
    public class WebbethBroadsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Webbeth Broadsword");
            Tooltip.SetDefault("A sword... made of webs?!");
        }

        public override void SetDefaults()
        {
            item.value = 10000;
            item.width = 2;
            item.height = 2;
            item.useStyle = 1;
            item.useTime = 20;
            item.useAnimation = 20;
            item.rare = 3;
            item.autoReuse = true;

            item.damage = 21;
            item.knockBack = 5;
            item.crit = 2;
            item.melee = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            // Takes: 10 Webbeth Bars
            recipe.AddIngredient(ItemType<WebbethBar>(), 10);
            // In: Furnace
            recipe.AddTile(TileID.Furnaces);
            // To make: A webbeth broadsword
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}