using productRegister.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productRegister.Domain.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
    }
}
