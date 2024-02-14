using BusinessLogicLayer.Extensions;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.Enums;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLogicLayer.Services.Concretes
{
    public class HashService : IHashService
    {
        public string HashPassword(string password, string salt)
        {
            password.ThrowIfNull("", CustomException.ParameterValueNullException);
            salt.ThrowIfNull("", CustomException.ParameterValueNullException);



            using (var sha256 = SHA256.Create())
            {
                var passwordBytes = Encoding.UTF8.GetBytes($"{password}{salt}");
                var hashedBytes = sha256.ComputeHash(passwordBytes);

                var sb = new StringBuilder();

                foreach (var b in hashedBytes)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();


            }
        }



    }
}
