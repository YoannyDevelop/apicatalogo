﻿using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        
        {

        }

    } 
}
