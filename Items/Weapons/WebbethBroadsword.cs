using Terraria.ID;
using Terraria.ModLoader;
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
    }
}