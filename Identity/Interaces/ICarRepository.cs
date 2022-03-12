using Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Interaces
{
    public interface ICarRepository
    {
        Task<List<Car>> GetAllCarsAsync();
        Task<Car> GetCarByIdAsync(int id);
        Task<Car> CreateTodoAsync(Car car);
        Task<Car> UpdateTodoAsync(Car updatedCar);
        Task<Car> DeleteTodoAsync(int id);
    }
}
