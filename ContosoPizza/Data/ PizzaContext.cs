using Microsoft.EntityFrameworkCore;
using ContosoPizza.Models;

namespace ContosoPizza.Data;
public class PizzaContext : DbContext
{
    public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
    {
    }
    DbSet<Pizza> Pizzas => Set<Pizza>();
    DbSet<Sauce> Sauces => Set<Sauce>();
    DbSet<Topping> Toppings => Set<Topping>();
}