using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsFinanseSystem.BaseDate;

namespace WindowsFormsFinanseSystem.BusinessLogic
{
    public class CategoryService
    {
        /// <summary>
        /// Получает категорию из репозитория
        /// </summary>
        /// <returns></returns>
        public static List<ICategory> GetCategory()
        {
            return DateCategory.Instance.Categorys.Select(t => t as ICategory).ToList();
        }

        /// <summary>
        /// Добавляет категорию в репозиторий
        /// </summary>
        /// <returns></returns>
        public static void AddCategory(string name, TransactionType type)
        {
            Category cat = new Category(name, type);
            try
            {
                DateCategory.Instance.AddCategory(cat);
            }
            catch
            {
                throw new Exception("Не удалось добавить транцакцию!");
            }
        }

        /// <summary>
        /// Удаляет категорию из репозитория
        /// </summary>
        /// <returns></returns>
        public static void RemoveCategory(ICategory category)
        {
            try
            {
                DateCategory.Instance.RemoveCategory(category as Category);
            }
            catch
            {
                throw new Exception("Не удалось удалить транцакцию!");
            }
        }
    }
}
