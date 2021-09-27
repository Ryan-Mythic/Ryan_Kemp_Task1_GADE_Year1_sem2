using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Game_2D {
    //Q.2.6
    class Hero:Character{


        int startingHP;
        int maxHP;
        char symbol;

        public Hero(int x, int y, int HP, int startingHP, char symbol) : base(x, y) {
            this.HP = HP;
            this.startingHP = startingHP;
            this.symbol = symbol;
        }

        //again ReturnMove() method not sure which method to override? .... GOES HERE 
        

    }
}
