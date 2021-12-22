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
    class FamilyMemberRepository
    {
        private static FamilyMemberRepository _instance;

        private List<FamilyMember> _hash;

        private static string bank_account = @"FamilyMember.dat";
        private FamilyMemberRepository()
        {
            if (!File.Exists(bank_account))
            {
                using (FileStream fl = new FileStream(bank_account, FileMode.CreateNew)) { }
                _hash = new List<FamilyMember>();
                return;
            }
             _hash = GetFamilyMember();
        }
        public List<FamilyMember> BankAccount => _hash;

        public static FamilyMemberRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FamilyMemberRepository();
                }
                return _instance;
            }
        }

        private List<FamilyMember> GetFamilyMember()
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<FamilyMember> fem_transaction = new List<FamilyMember>();
            using (FileStream fl = new FileStream(bank_account, FileMode.Open))
            {
                try
                {
                    fem_transaction = (List<FamilyMember>)bf.Deserialize(fl);
                }
                catch { }
            }
            return fem_transaction;
        }
        private void CommitChanges()
        {

            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fl = new FileStream(bank_account, FileMode.Create))
            {
                bf.Serialize(fl, _hash);
            }
        }

        public void AddFamilyMember(FamilyMember ba)
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

        public void RemoveBankAccount(FamilyMember ba)
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
        public void EditFamilyMember()
        {
            CommitChanges();
        }
    }
}
