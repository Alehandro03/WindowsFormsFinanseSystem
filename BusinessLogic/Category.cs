using System;
using System.Collections.Generic;

namespace WindowsFormsFinanseSystem.BusinessLogic
{
    [Serializable]
    class Category : ICategory
    {
        /// <summary>
        /// Название категории
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип категории
        /// </summary>
        public TransactionType Type { get; set; }

        /// <summary>
        /// Возвращает объект класса Category
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        public Category(string name, TransactionType type) 
        {
            Name = name;
            Type = type;
        }
    }
}
