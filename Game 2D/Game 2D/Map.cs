using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Game_2D
{
    class Map
    {
        int minHeight;
        int maxHeight;
        int minWidth;
        int maxWidth;
        int numEnemies;
        Random rand;

        public Map(int minWidth, int minHeight, int maxWidth, int maxHeight, int numEnemies)
        {
            this.minHeight = minHeight;
            this.minWidth = minWidth;
            this.maxHeight = maxHeight;
            this.maxWidth = maxWidth;
            this.numEnemies = numEnemies;

            //randoms a height and width for the map 
            rand = new Random();
            int randomHeight = rand.Next(minHeight, maxHeight);
            int randomWidth = rand.Next(minWidth, maxWidth);

            Tile[,] tileMap = new Tile[randomWidth, randomHeight];
            Enemy[] enemies = new Enemy[numEnemies];
            Create(Hero);
            for (int x = 0; x < enemies.Length; x++)
            {
                enemies = Create(Enemy);
            }

            UpdateVision();

        }

        public void UpdateVision()
        {

        }

        private Tile Create(TileType type)
        {

        }
    }


}