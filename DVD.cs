using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary
{
    public class DVD : LibraryItem
    {
        public DVD(int id, string title, string author, DateTime publicatonDate, int runTime ) : base(id, title, author, publicatonDate)
        {
            RunTime = runTime;
        }
        public DVD(LibraryItem item, int runTime): base(item.Id, item.Title, item.Author, item.PublicatonDate)
        {
            RunTime = runTime ;
        }
        public int RunTime { get; set; }
        public override string ToString()
        {
            return base.ToString() + " \n Run time: " + RunTime + "\n Type: DVD";
        }
    }
}
