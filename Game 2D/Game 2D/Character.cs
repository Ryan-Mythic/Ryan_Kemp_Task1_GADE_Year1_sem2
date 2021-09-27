using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Game_2D {

    //QUESTION 2.2 & QUESTION 2.3
    abstract class Character : Tile {   //character class used to make enemies and character

        protected int HP;
        protected int maxHP;
        protected int damage;

        //---create tile array
        public Tile[] characterVision = new Tile[4];

        public enum Movement {
            idle,               //no movement
            up,
            right,
            down,
            left
        }

        private Movement movement;

        public int getHP() {
            return HP;
        }

        public int getMaxHP() {
            return maxHP;
        }

        public int getDamage() {
            return damage;
        }

        public Movement getMovement() {
            return this.movement;
        }

        public void setHP(int HP) {
            this.HP = HP;
        }

        public void setMaxHP(int maxHP) {
            this.maxHP = maxHP;
        }

        public void setDamage(int damage) {
            this.damage = damage;
        }

        public void setMovement(Movement movement) {
            this.movement = movement;
        }

        char symbol;

        public Character(int x, int y, char symbol) : base(x,y) {
            this.symbol = symbol;
        }

        public Character(int x, int y) : base(x, y) {
        }

        public virtual void Attack(Character target) { 
            damage++;
            HP = HP - damage;
        }

        public bool IsDead() {
            if (HP <= 0) {
                return true;
            }
            return false;
        }

        public virtual bool CheckRange(Character target) {
            if (DistanceTo(target) == 1)
            { 
                return true;
            }
            return false;
        }

        private int DistanceTo(Character target) {      //calc dist between character and a target
            int totalDistance;
            totalDistance = (target.y - y) + (target.x - x);
            return totalDistance;
        }

        public void Move(Movement move) {
            if (move == Movement.down) {
                setY(y + 1);
            }
            if (move == Movement.up) {
                setY(y - 1);
            }
            if (move == Movement.right) {
                setX(x + 1);
            }
            if (move == Movement.left) {
                setX(x - 1);
            }
        }

        public abstract Movement ReturnMove(Movement move = 0);
        //{
        //    return;
        //}

        public override string ToString() {
            return "Character " + base.ToString();
        }
    }
}
