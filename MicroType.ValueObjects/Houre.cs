namespace MicroType.ValueObjects
{
    public class Houre
    {
        public readonly int Amount;

        public Houre(int amount)
        {
            Amount = amount;
        }

        public static Houre operator -(Houre left, Houre right)
        {
            return new Houre(left.Amount - right.Amount);
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            Houre? other = (Houre?)obj;
            return other != null && other.Amount == Amount;
        }
    }
}
