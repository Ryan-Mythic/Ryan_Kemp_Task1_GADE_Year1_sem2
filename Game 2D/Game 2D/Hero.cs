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

        public override Movement ReturnMove(Movement move /*= Movement.idle*/)
        {
            switch(move)
            {
                case Movement.idle:
                    return Movement.idle;
                case Movement.up:
                    if (characterVision[0].GetType() == typeof(EmptyTile))
                    {
                        return Movement.up;
                    }
                    else return Movement.idle;
                case Movement.right:
                    if (characterVision[1].GetType() == typeof(EmptyTile))
                    {
                        return Movement.right;
                    }
                    else return Movement.idle;
                case Movement.down:
                    if (characterVision[2].GetType() == typeof(EmptyTile))
                    {
                        return Movement.down;
                    }
                    else return Movement.idle;
                case Movement.left:
                    if (characterVision[3].GetType() == typeof(EmptyTile))
                    {
                        return Movement.left;
                    }
                    else return Movement.idle;
            }
            return Movement.idle;
        }

        public override string ToString()
        {
            string sOutput;
            sOutput = "Player stats:" + "\nHP: " + this.HP + "/" + this.maxHP + "\nDamage" + this.damage + "\n[" + x + "," + y + "]";
            return sOutput;
        }

    }
}
