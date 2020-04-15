using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
namespace Webbeth.Items.Consumables
{
    public class OrangeJuice : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orange Juice");
            Tooltip.SetDefault("Slightly bitter");
        }

        public override void SetDefaults()
        {
            item.value = 100;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 99;
            item.consumable = true;
            item.width = 10;
            item.height = 10;
            item.buffType = 25;
            item.buffTime = 7200;
            item.holdStyle = 1;
            item.rare = 2;
            item.noMelee = true;
            item.healLife = 15;
            item.buy = true;
        }
    }

   public class DD2Bartender : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.DD2Bartender)
            {
                shop.item[nextSlot].SetDefaults(ItemType<OrangeJuice>());
                shop.item[nextSlot].shopCustomPrice = 100;
                nextSlot++;
            }
        }
    }
}