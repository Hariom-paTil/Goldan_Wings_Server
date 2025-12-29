using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata.Ecma335;
using UserLogin.DTO;
using UserLogin.Repo_Pattern;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using AutoMapper;
using UserLogin.Models;
using UserLogin.Controllers;

namespace UserLogin.Service
{
    public class UserLoginService : IUserLoginService
    {
        private readonly IGenericRepository<Models.UserLoginInfo> _userRepository;
        private readonly IMapper _mapper;
       

        public UserLoginService(IGenericRepository<Models.UserLoginInfo> userRepository,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            


        }

        public async Task<string> AddNewUserAsync(UserLoginInfoDto dto)
        {
            bool exists = await _userRepository.ExistsAsync(u => u.Email == dto.Email);

            if (Regex.IsMatch(dto.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase) && !exists)
            {
                var userEntity = _mapper.Map<Models.UserLoginInfo>(dto);
                var hasher = new PasswordHasher<Models.UserLoginInfo>();
                userEntity.PasswordHash =
                    hasher.HashPassword(userEntity, dto.PasswordHash);


                await _userRepository.AddAsync(userEntity);

                return "User registered successfully";
            }
            else
            {
                return ("Invalid Email");
            }
            
           
        }
    }
}
