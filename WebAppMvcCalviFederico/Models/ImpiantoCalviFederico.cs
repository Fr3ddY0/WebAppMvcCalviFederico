using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAppMvcCalviFederico.Data;
using System;
using System.Linq;

namespace WebAppMvcCalviFederico.Models;
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WebAppMvcCalviFedericoContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<WebAppMvcCalviFedericoContext>>()))
        {
            // Look for any movies.
            if (context.Anagrafica.Any())
            {
                return;   // DB has been seeded
            }
            context.Anagrafica.AddRange(
                new Anagrafica
                {
                    Nome = "When Harry Met Sally",
                    Cognome = "When Harry Met Sally",
                    DataNascita = DateTime.Parse("1989-2-12"),
                    Via = "Romantic Comedy",
                    NumCivico = 12,
                    Citta = "When Harry Met Sally",
                    Cap = 12084,
                    Provincia = "Cuneo",
                    Telefono = 333333333,
                    Email = "email",
                    Social = "Instagram",
                    CodFiscale = "When Harry Met Sally"
                }
            );
            context.SaveChanges();
        }
    }
}
