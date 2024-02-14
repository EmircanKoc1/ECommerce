using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface IHashService
    {
        string HashPassword(string password , string salt);

        
    }
}
