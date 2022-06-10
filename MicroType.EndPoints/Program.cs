using MicroType.ValueObjects;

var contractHoure = new ContractHoure(new Houre(88));
var workingHoure = new WorkingHoure(new Houre(120));
var overTimeCalculator = new OverTimeCalculator();
var result = overTimeCalculator.Calculate(contractHoure, workingHoure);

Console.WriteLine(result.Houre.Amount);
