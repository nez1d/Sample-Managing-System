using Microsoft.EntityFrameworkCore;
using SampleApplicatoin.Domain.Models;
using SampleApplicatoin.Persistence;
using System.Net;
using System.Reflection;

namespace SampleApplication.Appliaction.Data.Repository
{
    public class EmploeeRepository
    {
        private readonly ApplicatoinDbContext _context;
        public EmploeeRepository(ApplicatoinDbContext context) =>
            _context = context;

        public async Task<bool> Create(string login, string password)
        {
            var user = GetByLogin(login);

            if(user != null)
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

            if (user != null)
            {
                return false;
            }
            else
            {
                var emploee = new Emploee
                {
                    Login = login,
                    ServieNumber = servieNumber,
                    PensionCode = pensionCode,
                    FirstName = firstName,
                    LastName = lastName,
                    Patronymic = patronymic,
                    Gender = gender,
                    BirthDate = birthDate,
                    Education = education,
                    Specialization = specialization,
                    Qualification = qualification,
                    MaritalStatus = maritalStatus,
                    Address = address,
                    PhoneNumber = phoneNumber,
                    PhotoPath = photoPath,
                    Photo = photo
                };
                _context.Emploees.AddAsync(emploee);
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
                .AsNoTracking()
                .FirstOrDefaultAsync(emploee => emploee.Id == id);
        }

        public async Task<Emploee> GetByLogin(string login)
        {
            return await _context.Emploees
                .AsNoTracking()
                .FirstOrDefaultAsync(emploee => emploee.Login == login);
        }

        public async Task<List<Emploee>> GetAll()
        {
            return await _context.Emploees
                .AsNoTracking()
                .OrderBy(emploee => emploee.Id)
                .ToListAsync();
        }
    }
}
