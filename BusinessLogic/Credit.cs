using System;
using System.Collections.Generic;

namespace WindowsFormsFinanseSystem.BusinessLogic
{
     public class Credit
    {
        /// <summary>
        /// Сумма
        /// </summary>
        public decimal Cost { get; }
   
        /// <summary>
        /// Процентная ставка 
        /// </summary>
        public decimal Rate { get; }

        /// <summary>
        /// Срок погашения  
        /// </summary>
        public int Period { get; }

        /// <summary>
        /// Возвращает объект класса Credit
        /// </summary>
        /// <param name="cost">Стоимость кредита</param>
        /// <param name="rate">Процентная ставка</param>
        /// <param name="period">Срок погашения</param>
        public Credit(decimal cost, decimal rate, int period)
        {
            Cost = cost;
            Rate = rate;
            Period = period;
        }

        /// <summary>
        /// Получить список ежемесячных платежей
        /// </summary>
        /// <returns>Список ежемесячных платежей</returns>
        public List<Payment> PaymentList()
        {
            decimal paymentSum, paymentPercentSum, remainsSum;
            remainsSum = Cost;
            List<Payment> list = new List<Payment>();

            for (int i = 0; i < Period; i++)
            {
                paymentSum = GetPay(remainsSum, Rate / 12 / 100, Period - i);
                paymentPercentSum = remainsSum * Rate / 12 / 100;
                remainsSum = remainsSum - paymentSum - paymentPercentSum;
                Payment p = new Payment { Month = i + 1, Pay = paymentSum, Percents = paymentPercentSum, Last = remainsSum };
                list.Add(p);
            }

            return list;
        }

        /// <summary>
        /// Расчитывает платеж по кредиту
        /// </summary>
        /// <param name="sum">Сумма</param>
        /// <param name="rate">Процентная ставка</param>
        /// <param name="period">Срок погашения</param>
        /// <returns></returns>
        private decimal GetPay(decimal sum, decimal rate, int period)
        {
            return sum * (rate + rate / ((decimal)Math.Pow((double)(1 + rate), period) - 1));
        }
    }
}
