using System;
using System.Diagnostics;
using System.IO;

namespace CalculatorSample.Logic
{
    public class Calculator
    {
        public ILogger _logger;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        public int Add(int x, int y)
        {
            _logger.Log($"Add {x} + {y}");
            return x + y;
        }

        public int Minus(int x, int y)
        {
            _logger.Log($"Minus {x} - {y}");
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            _logger.Log($"Multiply {x} * {y}");
            return x * y;
        }

        public double Divide(int x, int y)
        {
            _logger.Log($"Divide {x} / {y}");
            return Math.Round((double) x / (double) y, 2);
        }

        public double Degree(int x, int y)
        {
            _logger.Log($"Degree {x} ^ {y}");
            return Math.Round(Math.Pow(x, y), 3);
        }
    }

    public class Logger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("d:\\cources\\asp.net\\tdd\\CalculatorSample\\logger.txt", message);
            Debug.WriteLine("Debagggggggggg " + message);
            Console.WriteLine("Debagg " + message);
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }
}