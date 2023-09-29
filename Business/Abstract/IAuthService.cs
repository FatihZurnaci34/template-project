using Core.Security.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Dtos.Auths;

namespace Business.Abstract
{
    public interface IAuthService
    {
        public Task<RegisteredDto> CustomerForRegister(CustomerForRegisterDto customerForRegisterDto);
        public Task<RegisteredDto> SupplierForRegister(SupplierForRegisterDto supplierForRegisterDto);
        public Task<LoginedDto> CustomerForLogin(UserForLoginDto userForLoginDto);

    }
}
