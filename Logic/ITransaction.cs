using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFinanseSystem.Logic
{
    public interface ITransaction
    {
        DateTime Date { get; }

        decimal Sum { get; set; }

        TransactionType Type { get; set; }

        string Comment { get; set; }
    }
}
