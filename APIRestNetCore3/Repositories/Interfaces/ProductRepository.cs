using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface ProductRepository
    {
        Product GetById(int id);
        Product Insert(Product product);
        Product Update(Product product);
        bool Delete(int id);
    }
}
