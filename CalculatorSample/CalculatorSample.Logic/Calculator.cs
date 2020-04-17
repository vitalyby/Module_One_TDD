using System;
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
            _logger.Log($"Log Add: {x} + {y}");
            return x + y;
        }

        public int Minus(int x, int y)
        {
            _logger.Log($"Log Minus: {x} - {y}");
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            _logger.Log($"Log Multiply: {x} * {y}");
            return x * y;
        }

        public double Divide(int x, int y)
        {
            _logger.Log($"Log Divide: {x} / {y}");
            return Math.Round((double)x / (double)y, 2);
        }
    }

    public class Logger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("log.txt", message);
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }
}