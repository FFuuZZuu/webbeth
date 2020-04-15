using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Webbeth.Items.Weapons
{
    public class WebbethBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Webbeth Bow");
            Tooltip.SetDefault("[INSERT FUNNY TOOLTIP HERE]");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 40;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = 5;
            item.value = 10000;
            item.rare = 3;
            item.crit = 1;
            item.UseSound = SoundID.Item5;

            item.noMelee = true;
            item.ranged = true;
            item.damage = 25;
            item.knockBack = 4;
            item.shoot = 10;
            item.shootSpeed = 10f;
            item.useAmmo = AmmoID.Arrow;
        }
    }
}