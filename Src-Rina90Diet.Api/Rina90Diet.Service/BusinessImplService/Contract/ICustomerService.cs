﻿using Rina90Diet.Api.Web.Models;
using Rina90Diet.Front.ApiWeb;
using Rina90Diet.Model.FullDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rina90Diet.Service
{
    public interface ICustomerService
    {
        Task<CustomerProfile> GetCustomerByEmailAsync(string email);

        Task<IList<CustomerProfile>> GetAllCustomersAsync(int skip, int take);

        Task<CustomerProfile> GetCustomerByIdAsync(string customerId);

        Task<CustomerProfile> CreateCustomerAsync(CustomerCreateOrUpdate customer);

        Task<CustomerProfile> UpdateCustomerAsync(CustomerCreateOrUpdate customer);

        Task<bool> CheckPassword(string email, string password);

        Task<User> GetUserById(int userId);

        Task<bool> UpdateUser(User user);
    }
}
