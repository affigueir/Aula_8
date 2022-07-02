namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public virtual int Health { get; set; }
        public abstract float Value { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            System.Console.WriteLine($"This unit moved {movement}");
        }
        public override string ToString()
        {
            return $"Unit has {Health} health, and moved {movement} feet.";
        }
    }
}