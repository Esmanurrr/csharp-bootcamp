using CleanArch.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.DataAccess.Abstract
{
    public interface IBrandDal
    {
        void Add(Brand brand);

        public List<Brand> GetAll();
    }
}
