using Terraria;
using Terraria.ModLoader;

namespace Webbeth.Buffs
{
    public class Stuck : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Stuck!");
            Description.SetDefault("You can't move.");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.velocity *= 0;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed = 0;
        }
    }
}