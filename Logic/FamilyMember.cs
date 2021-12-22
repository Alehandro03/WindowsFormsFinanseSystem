using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFinanseSystem.Logic
{
    public class FamilyMember
    {
        public string Name { get; set; }

        Relationship Relationship { get; set; }

        public string RelationshipText => EnumText.GetRelationshipText(Relationship);
    }
}
