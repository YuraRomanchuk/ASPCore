﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> ListAsync();

        Task AddAsync(Book book);
    }
}
