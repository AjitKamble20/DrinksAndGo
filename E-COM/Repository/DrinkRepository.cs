using E_COM.Context;
using E_COM.Interface;
using E_COM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace E_COM.Repository
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext _appDbContext;

        public DrinkRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Drink> Drinks => _appDbContext.Drinks.Include(x => x.Category);

        public IEnumerable<Drink> PrefferedDrinks => _appDbContext.Drinks.Where(p => p.IsPreferredDrink).Include(c=>c.Category);

        public Drink GetDrinkById(int drinkId)=> _appDbContext.Drinks.FirstOrDefault(p => p.DrinkId==drinkId);

    }
}
