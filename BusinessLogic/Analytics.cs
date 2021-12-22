using System;
using System.Collections.Generic;
using WindowsFormsFinanseSystem.BaseDate;

namespace WindowsFormsFinanseSystem.BusinessLogic
{
    public static class Analytics
    {
        static decimal _balance;
        static decimal TotalSumm;
        static decimal _income = 0;
        static decimal _expenses = 0;

        public static void TotalSum(decimal totalSum)
        {
            decimal sum = totalSum;
            TotalSumm = sum;
        }

        public static decimal AddIncomSum(decimal sum, TransactionType type)
        {
            
            
            TransactionType Type = type;
            if (Type == TransactionType.Incoming)
            {
                TotalSumm += sum;
                _income += sum;
                return TotalSumm;
            }
            else
            {
                TotalSumm -= sum;
                _expenses += sum;
                return TotalSumm;
            }
        }
        public static decimal ShowTotalSum()
        {
            return TotalSumm;
        }
        public static decimal[] Diagram()
        {
            decimal income = _income;
            decimal expenses = _expenses;
            decimal[] mas = new decimal[2] { income, expenses };
            return mas;
        }   
        public static decimal Bills()
        {
            decimal balance = 0;
            List<IBankAccount> iba =  BankAccountService.GetBankAccount();
            foreach(var item in iba)
            {
                balance += item.Balance;
            }
            _balance = balance;
            return balance;

        }
    }
}
