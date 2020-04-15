using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Generation;
using Terraria.World.Generation;
using System.Collections.Generic;

namespace Webbeth
{
    public class WebbethWorld : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Tutorial Mod Ores", delegate (GenerationProgress progress)
                {
                    progress.Message = "Generating Webth Ores";
                    for (int i = 0; i < (int) ( (double) (Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
                    {
                        WorldGen.TileRunner(
                            WorldGen.genRand.Next(0, Main.maxTilesX), // X coord of tile
                            WorldGen.genRand.Next( (int) WorldGen.worldSurfaceLow, Main.maxTilesY), // Y coord of the tile
                            (double) WorldGen.genRand.Next(40, 60), // Strength
                            WorldGen.genRand.Next(2, 6), // Steps
                            mod.TileType("WebbethOre"), // Tile type
                            false, 
                            0f,
                            0f,
                            false,
                            true); // Overide existing tiles
                    }
                }));
            }
        }
    }
}