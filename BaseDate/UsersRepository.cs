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
    class UsersRepository
    {
        private static UsersRepository _instance;

        private List<User> _hash;

        private static string users_finename = @"users.dat";

        private UsersRepository()
        {
            if (!File.Exists(users_finename))
            {
                using (FileStream fl = new FileStream(users_finename, FileMode.CreateNew)) { }
                _hash = new List<User>();
                return;
            }
            _hash = GetUsers();
        }

        public List<User> Users => _hash;

        public static UsersRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UsersRepository();
                }
                return _instance;
            }
        }

        private List<User> GetUsers()
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<User> actual_users = new List<User>();
            using (FileStream fl = new FileStream(users_finename, FileMode.Open))
            {
                try
                {
                    actual_users = (List<User>)bf.Deserialize(fl);
                }
                catch { }
            }
            return actual_users;
        }

        public void RegisterUser(User user)
        {
            BinaryFormatter bf = new BinaryFormatter();

            _hash.Add(user);
            try  
            {
                using (FileStream fl = new FileStream(users_finename, FileMode.Create))
                {
                    bf.Serialize(fl, _hash);
                }
            }
            catch (Exception ex)
            {
                _hash.Remove(user);
                throw ex;
            }
        }
    }
}
