using YizhaAPI.Models;
namespace YizhaAPI.Services
{
    public class RestarauntService
    {
        static List<Restaraunt> Restaraunts { get; set; } = new List<Restaraunt>();
        static RestarauntService()
        {
  
        }
        public Task Import()
        {
            Restaraunts.Clear();
            Restaraunts.Add(new Restaraunt
            {
                Id = 1,
                Name = "McDonald's",
                Address = "Vilyamsa St. 85",
                Rating = 5,
                Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/McDonald%27s_Golden_Arches.svg/1200px-McDonald%27s_Golden_Arches.svg.png",
                Menu = new List<Menu>() { new Menu() { Id = 1,Name = "Cheeseburger",Price = 8,Weight = 20,Logo = "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Cheeseburger-1:1-3-product-tile-desktop?wid=829&hei=515&dpr=off", Rating = 5 }, new Menu() { Id = 2, Name = "Burger", Price = 8, Weight = 20, Logo = "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Cheeseburger-1:1-3-product-tile-desktop?wid=829&hei=515&dpr=off", Rating = 5 }, new Menu() { Id = 1, Name = "Cheeseburger", Price = 8, Weight = 20, Logo = "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Cheeseburger-1:1-3-product-tile-desktop?wid=829&hei=515&dpr=off", Rating = 5 }, new Menu() { Id = 2, Name = "Burger", Price = 8, Weight = 20, Logo = "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Cheeseburger-1:1-3-product-tile-desktop?wid=829&hei=515&dpr=off", Rating = 5 }    }
            });
            Restaraunts.Add(new Restaraunt
            {
                Id = 2,
                Name = "SushiYa",
                Address = "Vilyamsa St. 85",
                Rating = 3,
                Logo = "https://cdn1.pokupon.ua/uploaded/merchant_pages/2069/logos/original/su-logo.png",
                Menu = new List<Menu>() { new Menu() { Id = 1, Name = "Filadelphia", Price = 80, Weight = 120, Logo = "http://edimvkusno.org/images/materialsimages/filadelfia.jpg", Rating = 5 }, new Menu() { Id = 2, Name = "Maki", Price = 40, Weight = 50, Logo = "https://img3.zakaz.ua/upload7db9ac5476c451b306b945ea161bc99a.jpg.350x.jpg", Rating = 5 } }
            });
            return Task.CompletedTask;
        }

        public List<Restaraunt> GetRestaraunts()
        {
            Import();
            return Restaraunts;
        }

        public Restaraunt? GetById(int id) =>Restaraunts.FirstOrDefault(x => x.Id == id);
    }
}
