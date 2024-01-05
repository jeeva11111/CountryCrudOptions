using CountryCrudOptions.Data;
using CountryCrudOptions.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace CountryCrudOptions.Services
{
    public class UserServices : IUser
    {



        private readonly ApplicationDbcontext _context;


        public UserServices(ApplicationDbcontext context)
        {

            _context = context;
        }

        public async Task<List<User>> ListUser()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<int> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user.Id;
        }

        public Task<User> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateRecord(User user)
        {
            bool status = false;
            if (user != null)
            {
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
                status = true;
            }

            return status;
        }


        public async Task<bool> DeleteRecord(int Id)
        {
            bool status = false;
            if (Id != 0)
            {
                var data = await _context.Users.Where(x => x.Id == Id).FirstOrDefaultAsync();
                if (data != null)
                {
                    _context.Users.Remove(data);
                    await _context.SaveChangesAsync();
                    status = true;
                }
            }
            return status;
        }

        public async Task<IEnumerable<City>> Getcitys()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task<IEnumerable<Country>> Getcountries()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task<IEnumerable<City>> GetCityById(int stateId)
        {
            if (stateId != 0)
            {
                return await _context.Cities.Where(c => c.stateId == stateId).ToListAsync();
            }
            return null;
        }

        public async Task<IEnumerable<State>> GetStatesByCountryId(int countryId)
        {
            if (countryId != 0)
            {
                return await _context.States.Where(s => s.CountryId == countryId).ToListAsync();
            }

            return null;
        }

        public async Task<IEnumerable<State>> Getstates()
        {
            return await _context.States.ToListAsync();
        }

    }
}


