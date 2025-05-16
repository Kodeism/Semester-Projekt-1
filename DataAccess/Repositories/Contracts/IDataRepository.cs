using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Contracts
{
    internal interface IDataRepository
    {
        public Bolig CreateBolig(Bolig bolig);
        public Ejendomsmægler CreateEjendomsmægler(Ejendomsmægler ejendomsmægler);
    }
}
