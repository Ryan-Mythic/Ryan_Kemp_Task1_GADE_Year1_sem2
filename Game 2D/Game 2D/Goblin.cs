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
            } while (character)
        }
        //ReturnMove() method not sure which method to override? .... GOES HERE 
    }
}
