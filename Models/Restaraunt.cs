namespace YizhaAPI.Models
{
    public class Restaraunt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
        public string Logo { get; set; }

        //Inner Data 
        public ICollection<Menu> Menu { get; set; }   
    }
}
