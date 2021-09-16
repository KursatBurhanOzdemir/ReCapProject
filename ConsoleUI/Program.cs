using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;


namespace ConsoleUI
{
    class Program
    {
        
       public static void Main(string[] args)
        { CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            // carManager.Add(new Car { CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 120, ModelYear = 2010, Description = "benzinli" });
            //Car car1 = new Car();
            //car1.CarId = 1;
            //car1.BrandId = 1;
            //car1.ColorId = 1;
            //car1.ModelYear = 2013;
            //car1.DailyPrice = 150;
            //car1.Description = "Benzin";
            //Car car2 = new Car();
            //car2.CarId = 2;
            //car2.BrandId = 2;
            //car2.ColorId = 3;
            //car2.ModelYear = 201;
            //car2.DailyPrice = 100;
            //car2.Description = "Benzin";
            //Brand brand1 = new Brand();
            //brand1.BrandId = 1;
            //brand1.BrandName = "Opel";
            //brandManager.Add(brand1);
            //Color color1 = new Color();
            //color1.ColorId = 1;
            //color1.ColorName = "Siyah";
            //colorManager.Add(color1);
            //Color color2 = new Color();
            //color2.ColorId = 2;
            //color2.ColorName = "Sarı";
            //colorManager.Add(color2);
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
                }
               
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

        }
    }
}
