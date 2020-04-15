using Webbeth.Buffs;
using Terraria.ModLoader;

namespace Webbeth
{
    public class WebbethPlayer : ModPlayer
    {
        public static bool SpiderVision = false;

        public override void ResetEffects()
        {
            SpiderVision = false;
        }
    }
}