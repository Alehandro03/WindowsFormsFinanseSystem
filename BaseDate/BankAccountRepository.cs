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
    class BankAccountRepository
    {
        private static BankAccountRepository _instance;

        private List<BankAccount> _hash;

        private static string bank_account = @"BankAccount.dat";

        private BankAccountRepository()
        {
            if (!File.Exists(bank_account))
            {
                using (FileStream fl = new FileStream(bank_account, FileMode.CreateNew)) { }
                _hash = new List<BankAccount>();
                return;
            }
            _hash = GetBankAccount();
        }


        public List<BankAccount> BankAccount => _hash;

        public static BankAccountRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BankAccountRepository();
                }
                return _instance;
            }
        }

        private List<BankAccount> GetBankAccount()
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<BankAccount> actual_transaction = new List<BankAccount>();
            using (FileStream fl = new FileStream(bank_account, FileMode.Open))
            {
                try
                {
                    actual_transaction = (List<BankAccount>)bf.Deserialize(fl);
                }
                catch { }
            }
            return actual_transaction;
        }

        private void CommitChanges()
        {

            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fl = new FileStream(bank_account, FileMode.Create))
            {
                bf.Serialize(fl, _hash);
            }
        }

        public void AddBankAccount(BankAccount ba)
        {
            _hash.Add(ba);
            try
            {
                CommitChanges();
            }
            catch (Exception ex)
            {
                _hash.Remove(ba);
                throw ex;
            }
        }

        public void RemoveBankAccount(BankAccount ba)
        {
            _hash.Remove(ba);
            try
            {
                CommitChanges();
            }
            catch (Exception ex)
            {
                _hash.Add(ba);
                throw ex;
            }
        }

        public void EditBankAccount()
        {
            CommitChanges();
        }
    }
}
