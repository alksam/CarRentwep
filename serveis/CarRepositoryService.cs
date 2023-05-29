using RentCar;
using static CarRentwep.serveis.CarRepositoryService;

namespace CarRentwep.serveis
{
    public class CarRepositoryService: ICarRepositoryService
    {

        /*
         *  private int _id;
         *  private string _name;
         *  private double _pris;
         * 
         */
        
        
            private List<Car> _liste = new List<Car>()
        {
            new Car(1,"Audi",200),
            new Car(2,"BMW",250),
            new Car(3,"Seat",190)

        };


            public Car Delete(int id)
            {
                Car car = GetById(id); // kan kaste KeyNotFoundException

                _liste.Remove(car);
                return car;
            }

            public List<Car> GetAll()
            {
                return new List<Car>(_liste);
            }

            public Car GetById(int id)
            {
                foreach (Car c in _liste)
                {
                    if (c.Id == id)
                    {
                        return c;
                    }
                }

                throw new KeyNotFoundException();
            }


            public Car Create(Car car)
            {
                _liste.Add(car);
                return car;
            }

            public Car Update(int id, Car car)
            {
                Car updateCar = GetById(id); // kan kaste end KeyNotFoundException

                int ix = _liste.IndexOf(updateCar);
                _liste[ix] = car;

                return _liste[ix];
            }
        }
    }


