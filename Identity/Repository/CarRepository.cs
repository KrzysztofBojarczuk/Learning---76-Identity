using Identity.Data;
using Identity.Interaces;
using Identity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Identity.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly DataContext _ctx;
        public async Task<Car> CreateTodoAsync(Car car)
        {
            _ctx.Cars.Add(car);
            await _ctx.SaveChangesAsync();
            return car;
            
        }

        public async Task<Car> DeleteTodoAsync(int id)
        {
            var car = await _ctx.Cars.FirstOrDefaultAsync(x => x.CarId == id);
            if (car == null)
            {
                return null;
            }
            await _ctx.SaveChangesAsync();
            return car;

        }

        public async Task<List<Car>> GetAllCarsAsync()
        {
            return await _ctx.Cars.ToListAsync();
        }

        public async Task<Car> GetCarByIdAsync(int id)
        {
            var car = await _ctx.Cars.FirstOrDefaultAsync(x => x.CarId == id);
            if (car == null)
            {
                return null;
            }
             
     
            return car;
        }

        public async Task<Car> UpdateTodoAsync(Car updatedCar)
        {
            
            await _ctx.SaveChangesAsync();
            return updatedCar;
        }
    }
}