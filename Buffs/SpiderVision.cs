using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Webbeth.Buffs
{
    public class SpiderVision : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Spider Vision!");
            Description.SetDefault("You can see in the dark!");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            WebbethPlayer.SpiderVision = true;
        }
    }

    public class LightModifier : GlobalWall
    {
        private float NightVisionStrength;

        public override void ModifyLight(int i, int j, int type, ref float r, ref float g, ref float b)
        {
            if (WebbethPlayer.SpiderVision)
            {
                NightVisionStrength = 0.1f;
            } 
            else
            {
                NightVisionStrength = 0f;
            }

            if (NightVisionStrength > 0)
            {
                r = MathHelper.Clamp(r + NightVisionStrength, 0, 1);
                g = MathHelper.Clamp(g + NightVisionStrength, 0, 1);
                b = MathHelper.Clamp(b + NightVisionStrength, 0, 1);
            }
        }
    }
}