using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsFinanseSystem.BaseDate;

namespace WindowsFormsFinanseSystem.BusinessLogic
{

    [Serializable]
    static class BankAccountService
    {
        /// <summary>
        /// Получает счет
        /// </summary>
        /// <returns></returns>
        public static List<IBankAccount> GetBankAccount()
        {
            return BankAccountRepository.Instance.BankAccount.Select(t => t as IBankAccount).ToList();
        }

        /// <summary>
        /// Добавляет счет
        /// </summary>
        /// <returns></returns>
        public static void AddBankAccount(string name, string comment, decimal balance)
        {
            BankAccount tran = new BankAccount(name, comment, balance);
            try
            {
                BankAccountRepository.Instance.AddBankAccount(tran);
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось добавить транзацию!", ex);
            }
        }

        /// <summary>
        /// Удаляет счет
        /// </summary>
        /// <returns></returns>
        public static void RemoveBankAccount(IBankAccount account)
        {
            try
            {
                BankAccountRepository.Instance.RemoveBankAccount(account as BankAccount);
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось удалить транзацию!", ex);
            }
        }

        /// <summary>
        /// Изменяет счет
        /// </summary>
        /// <returns></returns>
        public static void EditBankAccount()
        {
            BankAccountRepository.Instance.EditBankAccount();
        }
    }
}
