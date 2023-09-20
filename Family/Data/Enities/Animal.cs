using System.ComponentModel.DataAnnotations.Schema;

namespace Family.Data.Enities
{
    public class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }

        [ForeignKey("Family")]
        public int FamilyId { get; set; }

        public Familyy Family { get; set; }
    }
}
