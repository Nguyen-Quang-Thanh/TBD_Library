﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.Entities;

namespace TBD_library.Data.EF
{
    public class TBD_libraryDBContext : DbContext
    {
        public TBD_libraryDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<User> Users { get; set; }
        
        // Post feature
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostInCategory> PostInCategories { get; set; }
        public DbSet<Category> Categories { get; set; }

        // Book feature
        public DbSet<Book> Books { get; set; }
        public DbSet<BookInCategory> BookInCategories { get; set; }
        public DbSet<BCategory> BCategories { get; set; }
        public DbSet<BorrowBook> BorrowBooks { get; set; }
        public DbSet<LogBorrowBook> LogBorrowBooks { get; set; }

        //Cinama feature
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieInCategory> MovieInCategories { get; set; }
        public DbSet<MCategory> MCategories { get; set; }
        public DbSet<LogCinema> LogCinemas { get; set; }
        public DbSet<LogRegistration> LogRegistrations { get; set; }

        //Room faeture
        public DbSet<BorrowRoom> BorrowRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
