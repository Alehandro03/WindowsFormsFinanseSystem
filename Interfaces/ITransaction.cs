using System;
using WindowsFormsFinanseSystem.Interfaces;

namespace WindowsFormsFinanseSystem.BusinessLogic
{
    public interface ITransaction
    {
        IUser User { get; set; }
        string UserName { get; }
        string Category { get; set; }
        IBankAccount Account { get; set; }
        DateTime Date { get; set; }

        decimal Sum { get; set; }

        string Comment { get; set; }
        TransactionType Type { get; set; }
      
    }
}
