using System;
using System.Collections.Generic;
using WindowsFormsFinanseSystem.Interfaces;

namespace WindowsFormsFinanseSystem.BusinessLogic
{
    [Serializable]
     class Transaction : ITransaction
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public IUser User { get; set; }

        /// <summary>
        /// Категория
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Счет
        /// </summary>
        public IBankAccount Account { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        private decimal _sum;
        public decimal Sum
        {
            get => _sum;

            set
            {
                if (value != 0) _sum = value;
                else throw new ArgumentException("Транзакция не может быть равна 0!");
            }
        }

        /// <summary>
        /// Тип транзакции
        /// </summary>
        public TransactionType Type { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        private string _comment;
        public string Comment
        {
            get => _comment;

            set
            {
                if (value != string.Empty) _comment = value;
                else throw new Exception("Вы ввели пустую строку!");
            }
        }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string UserName => User?.Name ?? "";

        /// <summary>
        /// Возвращает объект класса Transsaction
        /// </summary>
        /// <param name="sum">Имя</param>
        /// <param name="type">Тип</param>
        public Transaction(decimal sum, TransactionType type)
        {
            Sum = sum;
            Type = type;
        }

        /// <summary>
        /// Возвращает объект класса Transsaction
        /// </summary>
        /// <param name="datetime">Дата</param>
        /// <param name="user">Пользователь</param>
        /// <param name="category">Категория</param>
        /// <param name="sum">Сумма</param>
        /// <param name="type">Тип транзакции</param>
        /// <param name="comment">Комментарий</param>
        public Transaction(DateTime datetime, IUser user, string category, decimal sum, TransactionType type, string comment)
        {
            Date = datetime;
            User = user;
            Category = category;
            Sum = sum;
            Type = type;
            Comment = comment;
        }

       
    }
}

