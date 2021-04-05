using Dapper;
using Microsoft.Extensions.Configuration;
using ReactCoreCRUD.Entities;
using ReactCoreCRUD.Interfaces;
using ReactCoreCRUD.Repository.Queries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReactCoreCRUD.Repository
{
    public class UserDetailsRepository : BaseRepository, IUserDetailsRepository
    {
        private readonly ICommandText _commandText;

        public UserDetailsRepository(IConfiguration configuration, ICommandText commandText) : base(configuration)
        {
            _commandText = commandText;
        }

        public async Task<IEnumerable<UserDetails>> GetAllAsync()
        {

            return await WithConnection(async conn =>
            {
                var query = await conn.QueryAsync<UserDetails>(_commandText.GetAllUsers);
                return query;
            });

        }

        public async Task<UserDetails> GetByIdAsync(int id)
        {
            return await WithConnection(async conn =>
            {
                var query = await conn.QueryFirstOrDefaultAsync<UserDetails>(_commandText.GetUserById, new { Id = id });
                return query;
            });
        }

        public async Task AddAsync(UserDetails entity)
        {
            try
            {
                await WithConnection(async conn =>
                {
                    await conn.ExecuteAsync(_commandText.InsertUser, new
                    {
                        entity.LocationId,
                        entity.EmployeeType,
                        entity.ContractEndate,
                        entity.ContractStartdate,
                        entity.Designation,
                        entity.DrivingLicence,
                        entity.DrivingLicenceExpiryDate,
                        entity.DrivingLicenceFilePath,
                        entity.Email,
                        entity.EmiratesID,
                        entity.EmiratesIDExpiryDate,
                        entity.EmiratesIDFilePath,
                        entity.MobileNo,
                        entity.Name,
                        entity.Nationality,
                        entity.PassportExpiryDate,
                        entity.PassportNo,
                        entity.PassportFilePath,
                        entity.Section,
                        entity.PersonPhotoPath
                    });
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public async Task UpdateAsync(UserDetails entity, int Id)
        {
            try
            {
                await WithConnection(async conn =>
                {
                    await conn.ExecuteAsync(_commandText.UpdateUser, new
                    {
                        entity.LocationId,
                        entity.EmployeeType,
                        entity.ContractEndate,
                        entity.ContractStartdate,
                        entity.Designation,
                        entity.DrivingLicence,
                        entity.DrivingLicenceExpiryDate,
                        entity.DrivingLicenceFilePath,
                        entity.Email,
                        entity.EmiratesID,
                        entity.EmiratesIDExpiryDate,
                        entity.EmiratesIDFilePath,
                        entity.MobileNo,
                        entity.Name,
                        entity.Nationality,
                        entity.PassportExpiryDate,
                        entity.PassportNo,
                        entity.PassportFilePath,
                        entity.Section,
                        entity.PersonPhotoPath,
                        Id
                    });
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public async Task DeleteAsync(int id)
        {

            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(_commandText.DeleteUser, new { Id = id });
            });
        }
    }
}
