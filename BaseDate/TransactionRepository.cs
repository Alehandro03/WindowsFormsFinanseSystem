using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsFinanseSystem.BusinessLogic;

namespace WindowsFormsFinanseSystem.BaseDate
{
    class TransactionRepository
    {
        private static TransactionRepository _instance;

        private List<Transaction> _hash;

        private static string transaction_finename = @"Transactions.dat";

        private TransactionRepository()
        {
            if (!File.Exists(transaction_finename))
            {
                using (FileStream fl = new FileStream(transaction_finename, FileMode.CreateNew)) { }
                _hash = new List<Transaction>();
                return;
            }
            _hash = GetTransactions();
        }

        public List<Transaction> Transactions => _hash;

        public static TransactionRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TransactionRepository();
                }
                return _instance;
            }
        }

        private List<Transaction> GetTransactions()
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<Transaction> actual_transaction = new List<Transaction>();
            using (FileStream fl = new FileStream(transaction_finename, FileMode.Open))
            {
                try
                {
                    actual_transaction = (List<Transaction>)bf.Deserialize(fl);
                }
                catch { }
            }
            return actual_transaction;
        }

        private void CommitChanges()
        {
  
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fl = new FileStream(transaction_finename, FileMode.Create))
            {
                bf.Serialize(fl, _hash);
            }
        }

        public void AddTransaction(Transaction transaction)
        {
            _hash.Add(transaction);    
            try   
            {
                CommitChanges();
            }
            catch (Exception ex)    
            {
                _hash.Remove(transaction);     
                throw ex;       
            }
        }

        public void RemoveTransaction(Transaction transaction)
        {
            _hash.Remove(transaction);    
            try
            {
                CommitChanges();
            }
            catch (Exception ex)    
            {
                _hash.Add(transaction);     
                throw ex;       
            }
        }

        public void EditTransaction()
        {
            CommitChanges();
        }
    }
}
