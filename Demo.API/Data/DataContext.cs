using System;
using Demo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
