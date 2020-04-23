using System;
using System.IO;
using System.Security.Principal;

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

        public int[] SearchNumbers(int x, int y)
        {
            _logger.Log($"Log SearchNumbers: {x} and {y}");
            var result = new int[] { };

            //проверка на отрицательные входные параметры
            if (x < 0 || y < 0)
            {
                throw new ArgumentOutOfRangeException("Param < 0", new Exception());
            }

            //если входные параметры с нулями, отдалим пустой массив
            if (x == 0 || y == 0)
            {
                return result;
            }

            var cnt = 0;
            var minValue = 0;
            var maxValue = 0;

            for (var curValueIndex = 1; curValueIndex < Convert.ToInt32("9".PadRight(y, '9')); curValueIndex++)
            {
                var sumValues = 0;
                var lengthValue = curValueIndex.ToString().Length;

                //только для чисел, длина которых равна у
                if (lengthValue == y)
                {
                    for (var ii = 0; ii < lengthValue; ii++)
                    {
                        var curValue = Convert.ToInt32(curValueIndex.ToString().Substring(ii, 1));
                        sumValues += curValue;

                    }
                }

                //если сумма соответствует входному параметру х
                if (sumValues == x)
                {
                    cnt++;
                    if (minValue == 0)
                    {
                        minValue = curValueIndex;
                    }

                    if (curValueIndex > maxValue)
                    {
                        maxValue = curValueIndex;
                    }
                }
            }

            //если ничего не найдено пойдет пустой массив, иначе заполняем
            if (cnt > 0)
            {
                result = new int[] { cnt, minValue, maxValue == 0 ? minValue : maxValue };
            }

            return result;
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