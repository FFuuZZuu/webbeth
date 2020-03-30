using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using Webbeth.Items.Placeable;
using Webbeth.Projectiles;

namespace Webbeth.Items.Weapons
{
    public class WebbethStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Webbeth Staff");
            Tooltip.SetDefault("Shoots a sticky web to slow down your enemy!");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 62;
            item.height = 62;
            item.value = 10000;
            item.rare = 3;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true;
            item.UseSound = SoundID.Item20;

            item.magic = true;
            item.damage = 23;
            item.mana = 10;
            item.shoot = ProjectileType<WebShot>();
            item.shootSpeed = 15f;
        }
    }
}