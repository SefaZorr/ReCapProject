﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<Car> GetById(int carId);



        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarsDtoByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarsDtoByColorId(int id);
        IDataResult<CarDetailDto> GetCarsDtoByCarId(int id);


        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
