using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace Webbeth.Tiles
{
    public class WebbethBar : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileFrameImportant[Type] = true;
            drop = ItemType<Items.Placeable.WebbethBar>();

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Metal Bar");
            AddMapEntry(new Color(175, 175, 175), name);

            minPick = 55;
        }
    }
}