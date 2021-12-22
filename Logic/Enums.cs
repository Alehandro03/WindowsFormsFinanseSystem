using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFinanseSystem.Logic
{
    public enum TransactionType { Salary, Dividend, Food, CommunalPayments }

    public enum Relationship { Father, Mother, Children }
    public static class EnumText
    {
        static string[] _transaction_type_names = new string[] { "Зарплата", "Дивиденды", "Еда", "Коммуналка" };

        public static string GetTransactionTypeText(object enum_item)
        {
            if (enum_item is TransactionType)
                return _transaction_type_names[(int)((TransactionType)enum_item)];
            return "";
        }

        static string[] _relationship = new string[] { "Папа", "Мама", "Ребенок" };
        public static string GetRelationshipText(object enum_item)
        {
            if (enum_item is Relationship)
                return _relationship[(int)((Relationship)enum_item)];
            return "";
        }
    }
}
