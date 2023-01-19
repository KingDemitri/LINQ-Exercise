using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Games //: IEquatable<Games>
    {

        public string GameName { get; set; }

        public string ReleaseOrder { get; set; }

        public int ChronOrder { get; set; }
        public override string ToString()
        {
            return "Name: " + GameName + "\n"+ "Release Order: " + ReleaseOrder + "\n" + 
            "Chronological Release: " + ChronOrder + "\n";
        }

        //Referenced from https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0
        //public override bool Equals(object obj)
        //{
        //    if (obj == null) return false;
        //    Games objAsPart = obj as Games;
        //    if (objAsPart == null) return false;
        //    else return Equals(objAsPart);
        //}
        //public override int GetHashCode()
        //{
        //    return ReleaseOrder;
        //}
        //public bool Equals(Part other)
        //{
        //    if (other == null) return false;
        //    return (this.PartId.Equals(other.PartId));
        //}
        // Should also override == and != operators.
    }
}