using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            SettlerUnit Bandit = new SettlerUnit(20, 100);
            MilitaryUnit Soldier = new MilitaryUnit(0, 20, 20, 150);

            System.Console.WriteLine(Bandit.Health);
            Soldier.Attack(Bandit);
            System.Console.WriteLine(Bandit.Health);
            System.Console.WriteLine(Soldier.Value);
            System.Console.WriteLine(Bandit.Value);
            Bandit.Move();
            Soldier.Move();
            Soldier.Attack(Bandit);
        }
    }
}
