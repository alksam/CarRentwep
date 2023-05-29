namespace CarRentwep.modeldatabase
{
    public interface IDBWorker
    {
        
            public List<Person> GetAll();
            public Person GetById(int id);
            public Person Create(Person person);
            public Person Update(int id, Person person);
            public Person Delete(int id);


        }
    }

