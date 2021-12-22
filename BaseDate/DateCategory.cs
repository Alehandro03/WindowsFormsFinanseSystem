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
    class DateCategory
    {
        private static DateCategory _instance;

        private List<Category> _hash;

        private static string category_finename = @"Category.dat";

        private DateCategory()
        {
            if (!File.Exists(category_finename))
            {
                using (FileStream fl = new FileStream(category_finename, FileMode.CreateNew)) { }
                _hash = new List<Category>();
                return;
            }
            _hash = GetCategory();
        }
        private void CommitChanges()
        {

            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fl = new FileStream(category_finename, FileMode.Create))
            {
                bf.Serialize(fl, _hash);
            }
        }

        public List<Category> Categorys => _hash;

        public static DateCategory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DateCategory();
                }
                return _instance;
            }
        }

        private List<Category> GetCategory()
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<Category> actual_users = new List<Category>();
            using (FileStream fl = new FileStream(category_finename, FileMode.Open))
            {
                try
                {
                    actual_users = (List<Category>)bf.Deserialize(fl);
                }
                catch { }
            }
            return actual_users;
        }

        public void AddCategory(Category category)
        {
            _hash.Add(category);
            try
            {
                CommitChanges();
            }
            catch (Exception ex)
            {
                _hash.Remove(category);
                throw ex;
            }
        }

        public void RemoveCategory(Category category)
        {
            _hash.Remove(category);
            try
            {
                CommitChanges();
            }
            catch (Exception ex)
            {
                _hash.Add(category);
                throw ex;
            }
        }

    }
}
