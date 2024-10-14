using Microsoft.EntityFrameworkCore;
using SampleApplicatoin.Domain.Models;
using SampleApplicatoin.Persistence;
using System.Data.Entity;

namespace SampleApplication.Appliaction.Data.Repository
{
    public class EmploeeRepository
    {
        private ApplicationDbContext _context;
        public EmploeeRepository(ApplicationDbContext context) =>
            _context = context;

        public async Task<bool> Create(string login, string password)
        {
            var user = _context.Emploees
                .Where(emploee => emploee.Login == login)
                .FirstOrDefault();

            if (user != null)
            {
                return false;
            }
            else
            {
                var emploee = new Emploee
                {
                    Login = login,
                    Password = password,
                    ServieNumber = null,
                    PensionCode = "",
                    FirstName = "",
                    LastName = "",
                    Patronymic = "",
                    Gender = "",
                    BirthDate = null,
                    Education = "",
                    Specialization = "",
                    Qualification = "",
                    MaritalStatus = null,
                    Address = "",
                    PhoneNumber = "",
                    PhotoPath = "",
                    Photo = ""
                };
                _context.Emploees.AddAsync(emploee);
                _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> Update(string login, int? servieNumber, string? pensionCode, string? firstName,
                                 string? lastName, string? patronymic, string? gender, DateTime? birthDate,
                                 string? education, string? specialization, string? qualification,
                                 int? maritalStatus, string? address, string? phoneNumber,
                                 string? photoPath, string? photo)
        {
            var user = GetByLogin(login);

            if (user == null)
            {
                return false;
            }
            else
            {
                user.Login = login;
                user.ServieNumber = servieNumber;
                user.PensionCode = pensionCode;
                user.FirstName = firstName;
                user.LastName = lastName;
                user.Patronymic = patronymic;
                user.Gender = gender;
                user.BirthDate = birthDate;
                user.Education = education;
                user.Specialization = specialization;
                user.Qualification = qualification;
                user.MaritalStatus = maritalStatus;
                user.Address = address;
                user.PhoneNumber = phoneNumber;
                user.PhotoPath = photoPath;
                user.Photo = photo;
                
                _context.Emploees.Update(user);
                _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task Delete(int id)
        {
            
        }

        public async Task<Emploee> GetById(int id)
        {
            return await _context.Emploees
                .FirstOrDefaultAsync(emploee => emploee.Id == id);
        }

        public Emploee GetByLogin(string login)
        {
            return _context.Emploees
                .Where(emploee => emploee.Login == login)
                .FirstOrDefault();
        }

        public async Task<List<Emploee>> GetAll()
        {
            return await _context.Emploees
                .OrderBy(emploee => emploee.Id)
                .ToListAsync();
        }
    }
}
