using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFinanseSystem.BusinessLogic
{
    public interface ICategory
    {
        string Name { get; set; }

        //string Comment { get; set; }

        //Color CategoryColor { get; set; }

        TransactionType Type { get; set; }

        

    }
}
