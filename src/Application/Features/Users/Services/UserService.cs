﻿using Domain.Entities;
using Domain.Repositories.Common;
using System.Linq.Expressions;

namespace Application.Features.Users.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateUserAsync(User user, CancellationToken cancellationToken = default)
        {
            //await _unitOfWork.Users.InsertAsync(user, cancellationToken);
            //return await _unitOfWork.SaveChangesAsync();

            throw new NotImplementedException();
        }

        public async Task<User> GetByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            //return await _unitOfWork.Users.GetByIdAsync(id, cancellationToken);

            throw new NotImplementedException();
        }

        public async Task<List<User>> GetUsersAsync(CancellationToken cancellationToken = default)
        {
            //return await _unitOfWork.Users.GetAllAsync(cancellationToken);

            throw new NotImplementedException();
        }

        public async Task<bool> UserEmailExists(string email, CancellationToken cancellationToken = default)
        {
            //Expression<Func<User, bool>> filter = a => a.Email == email;

            //bool response = await _unitOfWork.Users.EntryExists(filter, cancellationToken);

            //return response;

            throw new NotImplementedException();
        }
    }
}
