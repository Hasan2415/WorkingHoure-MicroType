namespace MicroType.ValueObjects
{
    public class OverTimeHoure
    {
        public readonly Houre Houre;

        public OverTimeHoure(Houre houre)
        {
            Houre = houre;
        }

        public override int GetHashCode()
        {
            return Houre.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            OverTimeHoure? other = (OverTimeHoure?)obj;
            return other != null && Houre.Equals(other.Houre);
        }
    }
}
