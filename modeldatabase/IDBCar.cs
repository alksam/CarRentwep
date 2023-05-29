namespace CarRentwep.modeldatabase
{
   
        public interface IDBCar
        {

            public List<car1> GetAll();
            public car1 GetById(int id);
            public car1 Create(car1 carr);
            public car1 Update(int id, car1 carr);
            public car1 Delete(int id);


        }
    }



