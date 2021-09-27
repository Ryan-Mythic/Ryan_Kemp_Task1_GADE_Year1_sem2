using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Game_2D {
    //Q.2.5
    class Goblin : Enemy{
        public Goblin(int x, int y) : base(x, y, 1,10,100,'G') {

        }

        public override Movement ReturnMove(Movement move = Movement.idle)
        {
            int direction = 0;
            do
            {
                direction = random.Next(0, 4);
            } 
            while(characterVision[direction].GetType() == typeof(Obstacle) || characterVision[direction].GetType() == typeof(EmptyTile));
            
            switch(direction)
            {
                case 0:
                    return Movement.up;
                case 1:
                    return Movement.right;
                case 2:
                    return Movement.down;
                case 3:
                    return Movement.left;
                default:
                    return Movement.idle;
            }
        }

        public override string ToString()
        {
            return "Goblin " + base.ToString();
        }
    }
}
