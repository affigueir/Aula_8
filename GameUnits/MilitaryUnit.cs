using System;
namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; set; }
        public override int Health { get; set; }
        public override float Value { get; }
        private int attack, damage;

        public MilitaryUnit(int attackPower, int xp, int movement, int health) : base(movement, health)
        {
            AttackPower = attackPower;
            XP = xp;
            Health = health + xp;
            Value = attackPower + xp;
        }

        public void Attack (Unit u)
        {
            Random random = new Random();
            attack = random.Next(7, 21);
            damage = random.Next(1, 16);
            if (attack > 10 && attack < 19)
            {
                System.Console.WriteLine("You hit!");
                System.Console.WriteLine($"{u} took {damage} damage!"); 
                u.Health -= damage;      
            } 
            else if (attack > 18)
            {
                System.Console.WriteLine("Critical Hit!");
                System.Console.WriteLine($"{u} took {2 * damage} damage!");
                u.Health -= 2*damage;  
            }
            else
                System.Console.WriteLine("You did not hit the enemy :(");
        }

        public override string ToString()
        {
            return $"Soldier" + base.ToString() + $"And also has a power of {AttackPower} and {XP} XP";
        }
    }
}