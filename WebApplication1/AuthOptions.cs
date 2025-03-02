using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace WebApplication1;


public class AuthOptions
{
    public const string ISSUER = "MyAuthServer"; 
    public const string AUDIENCE = "MyAuthClient"; 
    const string KEY = "key"; 
    public static SymmetricSecurityKey GetSymmetricSecurityKey() => 
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
}