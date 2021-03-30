using E_COM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_COM.Interface
{
  public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; }

        IEnumerable<Drink> PrefferedDrinks { get; }

        Drink GetDrinkById(int drinkId);
    }
}
