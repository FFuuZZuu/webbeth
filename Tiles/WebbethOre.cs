using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace Webbeth.Tiles
{
    public class WebbethOre : ModTile
    {
        public override void SetDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 420; // Metal detector value
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 975; // Dust particle frequency, higher is less
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            minPick = 55;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Webth Ore");
            AddMapEntry(new Color(100, 100, 100), name);

            dustType = 84;
            drop = ItemType<Items.Placeable.WebbethOreItem>();
            soundType = 21;
            soundStyle = 1;
        }
    }
}