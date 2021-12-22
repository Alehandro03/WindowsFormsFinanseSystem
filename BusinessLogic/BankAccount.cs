using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFinanseSystem.BusinessLogic
{
    [Serializable]
    class BankAccount : IBankAccount
    {
        /// <summary>
        /// Название счета
        /// </summary>
        private string _name;
        public string Name
        {
            get => _name;

            set
            {
                if (value != string.Empty) _name = value;
                else throw new Exception("Введите название счета!");

            }
        }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        private string _userName;
        public string UserName
        {
            get => _userName;

            set
            {
                if (value != string.Empty) _userName = value;
                else throw new Exception("Введите имя пользователя!");

            }
        }

        /// <summary>
        /// Баланс
        /// </summary>
        public decimal Balance { get; set; }

        public BankAccount(string name, string userName, decimal balance)
        {
            Name = name;
            UserName = userName;
            Balance = balance;
        }
    }
}
