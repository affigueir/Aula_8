namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override int Health { get; set; }
        public override float Value { get; }

        public SettlerUnit(int health, int movement): base(health, movement)
        {
            Value = 5;
        }

        public void Settle()
        { 
            System.Console.WriteLine("Your unit has settled!");
        }
    }
}