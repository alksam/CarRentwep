namespace CarRentwep.modeldatabase
{
    public class Person
    {
        
            public int Id { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }

            public Person(int id, string name, string phone, string address)
            {
                Id = id;
                Name = name;
                Phone = phone;
                Address = address;
            }

            public Person() : this(-1, "dummy", "", "")
            {
            }

            public override string ToString()
            {
                return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Phone)}={Phone}, {nameof(Address)}={Address}}}";
            }
        }
}
