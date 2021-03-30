using E_COM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_COM.Interface
{
  public interface ICategoryRepository
    {
        IEnumerable<Category> categories { get; }

    }
}
