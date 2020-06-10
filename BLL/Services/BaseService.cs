using AutoMapper;
using DAL.UoF;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    class BaseService
    {
        protected readonly IMapper _mapper;
        protected readonly IUoF _uof;

        public BaseService(IMapper mapper, IUoF uof)
        {
            _mapper = mapper;
            _uof = uof;
        }
    }
}
