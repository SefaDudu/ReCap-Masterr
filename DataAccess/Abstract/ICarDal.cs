using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access.Abstract
{
    public interface ICarDal :IEntityRepository<Car>
    {
        List<CarDetailDTO> GetCarDetails();

    }
}
