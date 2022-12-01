
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TESTSIX.Models;

namespace TESTSIX.Repository.IRepository
{
    public interface ICoverType:IRepository<CoverType>
    {
        void Update(CoverType obj);

        void save();
    }
}
