using CountryCrudOptions.Models;

namespace CountryCrudOptions.Services
{
    public interface IUser
    {

        public Task<List<User>> ListUser();

        public Task<int> AddUser(User user);

        Task<User> GetUserById(int id);
        Task<bool> UpdateRecord(User user);
        //public void 
        Task<bool> DeleteRecord(int Id);


        // country drop down list 
        Task<IEnumerable<Country>> Getcountries();
        Task<IEnumerable<State>> Getstates();
        Task<IEnumerable<City>> Getcitys();

        Task<IEnumerable<State>> GetStatesByCountryId(int countryId);
        Task<IEnumerable<City>> GetCityById(int stateId);


    }
}
