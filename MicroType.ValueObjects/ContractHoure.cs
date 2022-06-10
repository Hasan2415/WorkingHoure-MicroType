namespace MicroType.ValueObjects
{
    public class ContractHoure
    {
        public readonly Houre Houre;

        public ContractHoure(Houre houre)
        {
            Houre = houre;
        }

        public override int GetHashCode()
        {
            return Houre.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            ContractHoure? other = (ContractHoure?)obj;
            return other != null && Houre.Equals(other.Houre);
        }
    }
}
