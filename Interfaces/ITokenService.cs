using CitasAppAPI.Entities;

namespace CitasAppAPI.Interfaces;

public interface ITokenService
{
    string CreateToken(User user);
}
