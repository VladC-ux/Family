namespace Family.Data.Enities
{
    public class Familyy
    {
        public int ID { get; set; }
      
        public ICollection<Person> People { get; set;}

        public ICollection<Animal> Animals { get; set; }
        



    }
}
