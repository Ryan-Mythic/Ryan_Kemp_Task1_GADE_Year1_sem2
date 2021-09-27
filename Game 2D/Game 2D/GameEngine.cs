using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Game_2D
{
    class GameEngine
    {
        private Map gameMap = new Map(8, 15, 8, 15, 3);

        public Map GameMap
        {
            get
            {
                return gameMap;
            }
        }

        public bool MovePlayer(Character.Movement direction)
        {
            switch(direction)
            {
                case Character.Movement.idle:
                    return false;
                case Character.Movement.up:
                    if (GameMap.hero.returnMove(direction) == Character.Movement.up)
                    {
                        if (GameMap.hero.characterVision[0].GetType == typeof(EmptyTile))
                        {
                            GameMap.ClearHero();
                            GameMap.hero.Move(Character.Movement.up);
                            return true;
                        }
                        else return false;
                    }
                    break;
                case Character.Movement.right:
                    if (GameMap.hero.returnMove(direction) == Character.Movement.right)
                    {
                        if (GameMap.hero.characterVision[1].GetType == typeof(EmptyTile))
                        {
                            GameMap.ClearHero();
                            GameMap.hero.Move(Character.Movement.right);
                            return true;
                        }
                        else return false;
                    }
                    break;
                case Character.Movement.down:
                    if (GameMap.hero.returnMove(direction) == Character.Movement.down)
                    {
                        if (GameMap.hero.characterVision[2].GetType == typeof(EmptyTile))
                        {
                            GameMap.ClearHero();
                            GameMap.hero.Move(Character.Movement.down);
                            return true;
                        }
                        else return false;
                    }
                    break;
                case Character.Movement.left:
                    if (GameMap.hero.returnMove(direction) == Character.Movement.left)
                    {
                        if (GameMap.hero.characterVision[3].GetType == typeof(EmptyTile))
                        {
                            GameMap.ClearHero();
                            GameMap.hero.Move(Character.Movement.left);
                            return true;
                        }
                        else return false;
                    }
                    break;
            }
        }

        public bool MovePlayer(Character.Movement direction)
        {

        }

        public void Update()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
