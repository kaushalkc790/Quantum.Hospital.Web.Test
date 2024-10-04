using Quantum.Hospital.Web.Test.Models;

namespace Quantum.Hospital.Web.Test.Services;

public interface IUserService
{
    public Task<IEnumerable<User>> GetUsers();
}