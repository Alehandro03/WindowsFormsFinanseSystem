using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFinanseSystem.BusinessLogic
{
    public class Contribution
    {
        /// <summary>
        /// Сумма вклада
        /// </summary>
        public decimal Sum { get; }

        /// <summary>
        /// Процентная ставка 
        /// </summary>
        public decimal Rate { get; }

        /// <summary>
        /// Срок вклада  
        /// </summary>
        public int Period { get; }

        /// <summary>
        /// Возвращает объект класса Contribution
        /// </summary>
        /// <param name="sum">Сумма вклада</param>
        /// <param name="rate">Процентная ставка</param>
        /// <param name="period">Срок вклада</param>
        public Contribution(decimal sum, decimal rate, int period)
        {
            Sum = sum;
            Rate = rate;
            Period = period;
        }

        /// <summary>
        /// Получить размер суммы при определенной процентной ставке
        /// </summary>
        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 1; i <= period; i++)
                result = result + result * rate / 100;
            return result;
        }
    }
}

