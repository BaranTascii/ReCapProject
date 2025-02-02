﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{ Id=1, BrandId=1,  ColorId=3, DailyPrice=3400000, ModelYear=2011, Description="Ferrari 458 Italia"},
                new Car{ Id=2, BrandId=1,  ColorId=1, DailyPrice=2300000, ModelYear=2009, Description="Ferrari 599 GTB"},
                new Car{ Id=3, BrandId=2,  ColorId=2, DailyPrice=5500000, ModelYear=2016, Description="Lamborghini Huracan"},
                new Car{ Id=4, BrandId=3,  ColorId=1, DailyPrice=1450000, ModelYear=2011, Description="Aston Martin V8 Vantage N 420"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == c.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
