
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TESTSIX.Repository.IRepository
{
    public interface IUnitofWork
    {
        ICategory categoty { get; }
        ICoverType coverType { get; }
        void save();


    }
}
