using RentCar;

namespace CarRentwep.serveis
{
    public interface ICarRepositoryService
    {
        public List<Car> GetAll();
        public Car GetById(int id);
        public Car Delete (int id);
       public Car Create(Car car);
       public Car Update (int id ,Car car);
    }
}
