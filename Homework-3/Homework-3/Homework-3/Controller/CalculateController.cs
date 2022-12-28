using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Controller
{
    internal class CalculateController
    {
        private readonly CalculateService _service;
        public CalculateController() => _service = new CalculateService();
        
        public void GetMultipleNumbersFromArray() => Console.WriteLine(_service.GetMultipleNumbersFromArray(GetArray()));
        
        public void GetEvenNumbersSumPowFromArray() => Console.WriteLine(_service.GetEvenNumbersSumPowFromArray(GetArray()));

        private double[] GetArray() => new double[] { 3, 4, 6.7, 10, 2, 15, 16, 18, 20, 33 };



        //double[] nums = { 3, 4, 6.7, 10, 2, 15, 16, 18, 20, 33 };
        //public void GetMultipleNumbersFromArray()
        //{
        //    CalculateService calculate = new();
        //    Console.WriteLine(calculate.GetMultipleNumbersFromArray(nums));
        //}
        //public void GetEvenNumbersSumPowFromArray()
        //{
        //    CalculateService calculate = new();
        //    Console.WriteLine(calculate.GetEvenNumbersSumPowFromArray(nums));
        //}
    }
}
