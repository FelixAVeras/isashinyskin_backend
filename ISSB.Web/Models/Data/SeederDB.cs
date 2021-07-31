using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISSB.Web.Models.Data
{
    public static class SeederDB
    {
        public static void InitializeDb(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(serviceProvider
                .GetRequiredService<DbContextOptions<DataContext>>()))
            {
                if (context.Products.Any())
                {
                    return;
                }

                context.Products.AddRange(
                    new Product { 
                        ProductName = "I'm from - Tonico de Arroz 150ml",
                        ProductDescription = "Tonico blanqueador, iluminador e hidratante formulado" +
                        " con un 77% de extracto de arroz.",
                        Price = 2078.00M,
                        Stock = 20
                    },
                    new Product
                    {
                        ProductName = "iUnik - Serum Rose Galactomyces Synergy 50ml",
                        ProductDescription = "Un serum extremadamente hidratante y nutritivo que " +
                        "proporciona una mejora completa de la piel con la union de la rosa y la levadura.",
                        Price = 1550.00M,
                        Stock = 15
                    },
                    new Product
                    {
                        ProductName = "Secret Key - Gel exfoliante Lemon Sparkling Peeling Gel 120ml",
                        ProductDescription = "Con agua y extracto de limon, este gel exfolia la queratina, " +
                        "la grasa y las impurezas para que la piel se sienta fresca e hidratada.",
                        Price = 860.00M,
                        Stock = 10
                    },
                    new Product
                    {
                        ProductName = "Etude House - Tratamiento contra granitos, espinillas y acne localizado 15ml",
                        ProductDescription = "Es un tratamiento suave contra granitos, espinillas y acne " +
                        "localizado que contiene acido salicilico, aceite de arbol de te y madecassoside que" +
                        " aporta energia extraida de las plantas naturales para que las pieles con " +
                        "imperfecciones se mantengas limpias, eliminando las areas afectadas" +
                        " con su potente efecto.",
                        Price = 1130.00M,
                        Stock = 25
                    },
                    new Product
                    {
                        ProductName = "TIA'M - Escencia de Baba de caracol azuleno y Azulene Snail & Azulene Water 180ml",
                        ProductDescription = "Escencia acuosa con un 87% de filtrado de baba de caracol y " +
                        "azuleno que previene la perdida de humedad y restaura el equilibrio agua-aceite " +
                        "de la piel, mientras la mantiene calmada e hidratada. Libre de Alcohol y adecuada " +
                        "para pieles sensibles",
                        Price = 1330.00M,
                        Stock = 20
                    },
                    new Product
                    {
                        ProductName = "iUnik - Serum antiedad Noni Light oil 150ml",
                        ProductDescription = "Serum infundido conextracto de fruta morinda y aceites " +
                        "de origen vegetal para proporcionar efectos antiedad que mejoren significativamente " +
                        "las lineas finas y arrugas, mientras hidratan y nutren la piel.",
                        Price = 1480.00M,
                        Stock = 32
                    },
                    new Product
                    {
                        ProductName = "MIZON - parche de gel para ojos intensivo reparador de caracol",
                        ProductDescription = "Este lujoso parche para ojos esta formulado para ofrecer " +
                        "nutricion y tonificar de forma radical la zona del contorno de los ojos.",
                        Price = 1340.00M,
                        Stock = 15
                    },
                    new Product
                    {
                        ProductName = "Some by MI - Protector Solar",
                        ProductDescription = "Protector solar respetuoso con los arrecifes de coral que forma una pantalla protectora contra los rayos UVA y UVB sin dejar restos blaquesinos en la piel.",
                        Price = 1060.00M,
                        Stock = 8
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
