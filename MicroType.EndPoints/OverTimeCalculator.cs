using MicroType.ValueObjects;

public class OverTimeCalculator
{
    public OverTimeHoure Calculate(ContractHoure contract, WorkingHoure working)
    {
        var result = working.Houre - contract.Houre;
        return new OverTimeHoure(result);
    }
}