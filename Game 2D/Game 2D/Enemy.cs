using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Game_2D {
    //Q2.4
    abstract class Enemy : Character {
        protected Random random;

        int damage;
        int startingHP;
        int maxHP;
        char symbol;

        public Enemy(int x, int y, int damage, int startingHP, int maxHP, char symbol) : base(x, y) {
            this.damage = damage;
            this.startingHP = startingHP;
            this.maxHP = maxHP;
            this.symbol = symbol;
        }

        public override string ToString() {
            //might need to fix this
            return typeof(Enemy).Name + " at [" + getX() + ","+getY() + "] (" + damage + " DMG)";
        }
    }
}
