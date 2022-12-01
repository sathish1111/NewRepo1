
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TESTSIX.Models;

namespace TESTSIX.Repository.IRepository
{
    public interface ICategory:IRepository<Category>
    {
        void Update(Category obj);

        void save();
    }
}
