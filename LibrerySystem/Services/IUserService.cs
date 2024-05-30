using AutoMapper;
using LibrerySystem.DTOs;
using LibrerySystem.Models;

namespace CustomerMicroService.Services
{
    public interface IUserService
    {
        bool EmailAlreadyExsist(string email, int? customerId = null);
        string CreateToken(string? newUserEmail = null);
        Task<bool> ValidateUser(LoginDTO loginDTO);
        Task<User> GetUserByEmail(string email);
        Task<User> CreateCustomer(RegisterDto registerDTO);
        Task UpdateCustomerRelatedInfo(int id, UpdateCustomerDTO updateCustomerDTO);
    }
}
