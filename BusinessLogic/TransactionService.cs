using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsFinanseSystem.BaseDate;
using WindowsFormsFinanseSystem.Interfaces;

namespace WindowsFormsFinanseSystem.BusinessLogic
{

    [Serializable]
    static class TransactionService
    {
        /// <summary>
        /// Получает транзакцию из репозитория
        /// </summary>
        /// <returns></returns>
        public static List<ITransaction> GetTransactions()
        {
            return TransactionRepository.Instance.Transactions.Select(t => t as ITransaction).ToList();
        }

        /// <summary>
        /// Добавляет транзакцию
        /// </summary>
        /// <param name="datetime">Дата</param>
        /// <param name="category">Категория</param>
        /// <param name="user">Пользователь</param>
        /// <param name="sum">Сумма</param>
        /// <param name="type">Тип транзакции</param>
        /// <param name="comment">Комментарий</param>
        public static void AddTransaction(DateTime datetime, string category, IUser user, decimal sum, 
            TransactionType type, string comment) 
        {
            Transaction tran = new Transaction(datetime, user, category, sum, type, comment); 
            try
            {
                TransactionRepository.Instance.AddTransaction(tran);
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось добавить транзацию!", ex);
            }
        }

        /// <summary>
        /// Удаляет транзакцию
        /// </summary>
        /// <param name="transaction"></param>
        public static void RemoveTransaction(ITransaction transaction)
        {
            try
            {
                TransactionRepository.Instance.RemoveTransaction(transaction as Transaction);
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось удалить транзацию!", ex);
            }
        }

        /// <summary>
        /// Изменяет транзакцию
        /// </summary>
        public static void EditTransaction()
        {
            TransactionRepository.Instance.EditTransaction();
        }
    }
}
