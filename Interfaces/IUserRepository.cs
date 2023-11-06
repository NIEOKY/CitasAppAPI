using CitasAppAPI.DTOs;
using CitasAppAPI.Entities;

namespace CitasAppAPI.Interfaces;

public interface IUserRepository
{
    Task<MemberDto> GetMemberAsync(string username);
    Task<IEnumerable<MemberDto>> GetMembersAsync();
    Task<User> GetUserByIdAsync(int id);
    Task<User> GetUserByUsernameAsync(string username);
    Task<IEnumerable<User>> GetUsersAsync();
    Task<bool> SaveAllAsync();
    void Update(User user);
}