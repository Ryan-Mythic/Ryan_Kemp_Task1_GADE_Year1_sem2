using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Game_2D {

    //QUESTION 2.1
    abstract class Tile {

        protected int x;
        protected int y;

        public enum TileType {
            Hero,
            Enemy,
            Gold,
            Weapon
        }

        private TileType tileType;

        public Tile(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public int getX() {
            return this.x;
        }

        public void setX(int x) {
            this.x = x;
        }

        public int getY() {
            return this.y;
        }

        public void setY(int y) {
            this.y = y;
        }


        public void setTileType(TileType tileType) {
            this.tileType = tileType;
        }

        public TileType getTileType() {
            return this.tileType;
        }


    }

    class Obstacle : Tile {
        public Obstacle() : base(1, 1) { }
    }

    class EmptyTile : Tile {
        public EmptyTile() : base(0, 0) { }
    }

}
