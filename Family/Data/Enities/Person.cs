using Family.EnumTypeOfPerson;
using System.ComponentModel.DataAnnotations.Schema;

namespace Family.Data.Enities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public Gender Gender { get; set; }

        [ForeignKey("Family")]
        public int FamilyId { get; set; }

        public Familyy Family { get; set; }
    }
}
