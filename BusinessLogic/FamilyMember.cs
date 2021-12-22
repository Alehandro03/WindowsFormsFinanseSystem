using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsFinanseSystem.Interfaces;

namespace WindowsFormsFinanseSystem.BusinessLogic
{
    [Serializable]
    class FamilyMember : IFamilyMember
    {
        /// <summary>
        /// Имя члена семьи
        /// </summary>
        private string _name;
        public string Name { get; set; }
        
        

        /// <summary>
        /// Тип родственных отношений
        /// </summary>
        public string TypeFamily { get; set; }

        /// <summary>
        /// Возвращает объект класса Familymember
        /// </summary>
        /// <param name="name">Имя члена семьи</param>
        /// <param name="typeFamily">Тип родственных отношений</param>
        public FamilyMember(string name, string typeFamily)
        {
            Name = name;
            TypeFamily = typeFamily;
        }
    }
}
