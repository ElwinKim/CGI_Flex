using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace API.Controllers.interfaces
{
    public interface ITokenService
    {
        string CreateToken(AuthenticationDTO authenticationDTO);
    }
}