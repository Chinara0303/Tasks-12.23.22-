using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CalculateService : ICalculateService
    {
        public double GetBetweenNumbersFromArray(double[] nums)
        {
            double multiple=1;
            foreach (double num in nums)
            {
                if (num>1 && num<20)
                {
                    multiple *= num;
                }
            }
            return multiple;
        }

        public double GetEvenNumbersSumPowFromArray(double[] nums)
        {
            double sum= 0;
            double power = 1;
            foreach (double num in nums)
            {
                if (num%2==0)
                {
                    sum += num;
                }
            }
            power = Math.Pow(sum, 2);
            return power;
        }
    }
}
