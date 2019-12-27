﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> ListAsync();
    }
}
