using CleanArch.Business.Dtos.Requests;
using CleanArch.Business.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Business.Abstract
{
    public interface IBrandService
    {
        CreatedBrandResponse Add(CreateBrandRequest brand);

        List<GetAllBrandResponse> GetAll();
    }
}
