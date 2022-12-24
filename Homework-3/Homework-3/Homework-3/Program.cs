
using ServiceLayer.Services;

CalculateService calculate = new();
double[] nums = { 3, 4, 6.7, 10,2, 15, 16, 18, 20, 33 };

Console.WriteLine(calculate.GetBetweenNumbersFromArray(nums));
Console.WriteLine(calculate.GetEvenNumbersSumPowFromArray(nums));