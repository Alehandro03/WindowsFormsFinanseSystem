namespace WindowsFormsFinanseSystem.BusinessLogic
{
    public enum TransactionType { Incoming, Outcoming };

    public enum Color { Red, Yellow, Green, Blue, Pink }

    public enum CategoryType { }

    //public static class EnumText
    //{
    //    static string[] _transaction_type = new string[] {"доходы","рассходы" };
    //    public static string GetEnumText(object enum_transaction)
    //    {
    //        if (enum_transaction is TransactionType)
    //            return _transaction_type[(int)((TransactionType)(enum_transaction))];
    //        return "";
    //    }
    //    public static List<string> GetEnumNames(Type enum_transaction)
    //    {
    //        if (enum_transaction == typeof(TransactionType))
    //            return _transaction_type.ToList();
    //        return null;
    //    }

        //    static string[] _transaction_type_names = new string[] { "Зарплата", "Дивиденды", "Продукты", "Коммуналка", "Автомобиль" };

        //    public static string GetTransactionTypeText(object enum_item)
        //    {
        //        if (enum_item is TransactionType)
        //            return _transaction_type_names[(int)((TransactionType)enum_item)];
        //        return "";
        //    }

        //    public static string[] _bank_account_type = new string[] { "Дебетовый счет", "Кредитный счет" };

        //    public static string GetBankAccountText(object enum_item)
        //    {
        //        if (enum_item is BankAccountType)
        //            return _bank_account_type[(int)((BankAccountType)enum_item)];
        //        return "";
        //    }

        //    public static List<string> GetEnumAccounts(Type enum_type)
        //    {
        //        if (enum_type == typeof(BankAccountType))
        //            return _bank_account_type.ToList();
        //        return null;
        //    }

        //    public static string[] _card_type = new string[] { "Сбер", "ВТБ", "Альфа-банк" };
        //    public static string GetCardText(object enum_item)
        //    {
        //        if (enum_item is BankAccountType)
        //            return _card_type[(int)((CardType)enum_item)];
        //        return "";
        //    }
    
}