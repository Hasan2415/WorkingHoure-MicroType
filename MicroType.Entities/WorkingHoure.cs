namespace MicroType.ValueObjects
{
    public class WorkingHoure
    {
        public readonly Houre Houre;

        public WorkingHoure(Houre houre)
        {
            Houre = houre;
        }

        public override int GetHashCode()
        {
            return Houre.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            WorkingHoure? other = (WorkingHoure?)obj;
            return other != null && Houre.Equals(other.Houre);
        }
    }
}
