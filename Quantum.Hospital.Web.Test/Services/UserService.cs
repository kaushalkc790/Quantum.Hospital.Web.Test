using System.Net.Http;
using System.Net.Http.Json;
using Quantum.Hospital.Web.Test.Models;

namespace Quantum.Hospital.Web.Test.Services;

public class UserService: IUserService
{
   private static string jsonApiUrl = "https://jsonplaceholder.typicode.com/users";
   private readonly HttpClient httpClient;

   public UserService(HttpClient httpClient)
   {
      this.httpClient = httpClient;
   }

   public async Task<IEnumerable<User>> GetUsers()
   {
      return await this.httpClient.GetFromJsonAsync<IEnumerable<User>>(jsonApiUrl);
   }
}