﻿using PicBook.Domain;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PicBook.ApplicationService
{
    public interface IUserService
    {
        Task<UserEntity> GetUserdByIdentifier(string userIdentifier);
        Task AddNewUser(UserEntity entity);

        Task<UserEntity> GetUserById(Guid userId);
    }
}