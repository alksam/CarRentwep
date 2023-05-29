namespace CarRentwep.modeldatabase
{
    public class store
    {

        public void strart()
        {
            DoCode(new DBWorkerException());
           

            static void DoCode(IDBWorker inWorker)
            {
                IDBWorker worker = inWorker;


                Console.WriteLine("====  Alle Personer ====");
                List<Person> personer = worker.GetAll();
                foreach (Person p in personer)
                {
                    Console.WriteLine(p);
                }


                Console.WriteLine("====  Person id 3 findes ====");
                Console.WriteLine(worker.GetById(3));

                Console.WriteLine("====  Person id 10 findes IKKE ====");
                try
                {
                    Console.WriteLine(worker.GetById(10));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


                Console.WriteLine("====  Opret Person ====");
                Person person = new Person(1, "Peter", "66557744", "Roskilde");
                Console.WriteLine(worker.Create(person));

                Console.WriteLine("====  Opdater Person ====");
                Person UpdatePerson = new Person(person.Id, "Peter Levinsky", "66557744", "Roskilde");
                Console.WriteLine(worker.Update(person.Id, UpdatePerson));

                try
                {
                    Console.WriteLine(worker.Update(10, UpdatePerson));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("====  Slet Person ====");
                Console.WriteLine(worker.Delete(person.Id));
            }
            DoCCode(new DBCarExeption());
            static void DoCCode(IDBCar incarss)
            {
                IDBCar bil = incarss;


                Console.WriteLine("====  Alle biler ====");
                List<car1> carr = bil.GetAll();
                foreach (car1 ca in carr)
                {
                    Console.WriteLine(ca);
                }


                Console.WriteLine("====  bil id 3 findes ====");
                Console.WriteLine(bil.GetById(3));

                Console.WriteLine("====  bil id 10 findes IKKE ====");
                try
                {
                    Console.WriteLine(bil.GetById(10));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


                Console.WriteLine("====  Opret bil ====");
                car1 carss = new car1(1,  "Bmw", 350);
                Console.WriteLine(bil.Create(carss));

                Console.WriteLine("====  Opdater car ====");
                car1 Updatecar = new car1(
                    carss.Id,
                    "Bmw",
                    350);
                Console.WriteLine(bil.Update(carss.Id, Updatecar));

                try
                {
                    Console.WriteLine(bil.Update(10, Updatecar));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("====  Slet biil ====");
                Console.WriteLine(bil.Delete(carss.Id));
            }
        }

      
    }
}
