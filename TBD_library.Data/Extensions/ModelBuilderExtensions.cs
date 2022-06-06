using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD_library.Data.Entities;
using TBD_library.Data.Enums;

namespace TBD_library.Data.Extention
{
    public static class ModelBuilderExtensions
    {
        
        public static void Seed(this ModelBuilder modelBuilder)
        {
            DateTime aDateTime = DateTime.Now;
            TimeSpan timeBorrowRoom = new System.TimeSpan(0, 2, 30, 0);
            TimeSpan timeWachingMovie = new System.TimeSpan(5, 0, 0, 0);
            TimeSpan timeMovie = new System.TimeSpan(0, 2, 0, 0);
            // about post
            modelBuilder.Entity<Post>().HasData(
                new Post() { 
                    Id= 1,
                    Title ="blog mẫu",
                    Conten = "dữ liệu mẫu",
                    Summary = "mẫu ban đầu" ,
                    Created_at = aDateTime.Date,
                    ViewCount = 0,
                    Status = ePostStatus.activity,
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category() { 
                    Id = 1 ,
                    Title = "thông báo",
                    Description = "những thông tin mới nhất từ thư viện luôn được cập nhật",
                }
            );
            modelBuilder.Entity<PostInCategory>().HasData(
                new PostInCategory()
                {
                    Post_id = 1 ,
                    Category_id =1
                }
            );
            modelBuilder.Entity<BorrowBook>().HasData(
                new BorrowBook()
                {
                    Id = 1,
                    Borrowed_date = aDateTime.Date,
                    Status = eBorrowBookStatus.borrowing,
                });
            // about books
            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    Id = 1,
                    Name = "hành trình về phương đông",
                    Summary = "sach hay",
                    Description = "cuốn sách hay nhất mọi thời đại khám phá nhữ giá trị vĩnh hằng",
                    Author = "Blair T.Spalding",
                    Img = "hanh-trinh-ve-phuong-dong.jpg",
                    Created_at = aDateTime.Date,
                    BorrowBook_id = 1,
                    Status = eBookStatus.Borrwed,
                    BorrowCount = 0,
                },
                new Book()
                {
                    Id = 2,
                    Name = "tôi tài giỏi bạn cũng thế",
                    Summary = "sach hay",
                    Description = "cuốn sách dạy ra các mẹo để có thể tối ưu tất cả những gì ta có thể làm",
                    Author = "Adam Khoo",
                    Img = "toi-tai-gioi-ban-cung-the.jpg",
                    Created_at = aDateTime.Date,
                    Status = eBookStatus.NotBorrwed,
                    BorrowCount = 0,
                }
            ) ;
            modelBuilder.Entity<BCategory>().HasData(
                new BCategory()
                {
                    Id = 1 ,
                    Title = "sách văn hóa",
                    Description ="khái phá giá trị của nền văn hóa , văn minh nhân loại",
                },
                new BCategory()
                {
                    Id = 2,
                    Title = "cuộc sống",
                    Description = "sách nói những gì lênh quan đến cuộc sống mọi thứ tác động đến chúng ta trong cuộc sống",
                }
            );
            modelBuilder.Entity<BookInCategory>().HasData(
                new BookInCategory()
                {
                    Book_id =1 ,
                    BCategory_id =1 ,
                },
                new BookInCategory()
                {
                    Book_id = 2,
                    BCategory_id = 2,
                }
            );

            // about meeting room
            modelBuilder.Entity<Room>().HasData(
                new Room()
                {
                    Id = 1,
                    RoomName = "phòng họp " + aDateTime.Date,
                    SessionTime = 1,
                    Room_date = aDateTime.Date,
                    Status = eRoomStatus.allowed,
                }
            );
            modelBuilder.Entity<BorrowRoom>().HasData(
                new BorrowRoom()
                {
                    Id = 1,
                    Borrow_date = aDateTime.Date,
                    Time = timeBorrowRoom,
                }
            );
            modelBuilder.Entity<BorrowInRoom>().HasData(
                new BorrowInRoom()
                {
                    Room_id = 1,
                    Borrow_id = 1,
                }
            );

            // about cinema
            modelBuilder.Entity<MCategory>().HasData(
                new MCategory()
                {
                    Id = 1,
                    Title = "tài liệu",
                    Description = "mô tả các khía cạnh văn hóa xã hội",
                },
                new MCategory()
                {
                    Id = 2,
                    Title = "hài kịch",
                    Description = "phim giải trí mang tính gây cười",
                },
                new MCategory()
                {
                    Id = 3,
                    Title = "anime",
                    Description = "phim được dựng nên bởi các nét vẽ sinh động",
                },
                new MCategory()
                {
                    Id = 4,
                    Title = "hành động",
                    Description = "thể loại phim mang tính chất kịch tính hồi hộp",
                }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    Id =1,
                    Name = "Quà tặng cuộc sống",
                    Summary = "phim nói về triết lý cuộc sống",
                    Time = timeMovie,
                },
                new Movie
                {
                    Id = 2,
                    Name = "đại chiến chén thánh",
                    Summary = "phim nói về cuộc chiến tranh dành chén thánh của các anh linh và master của họ",
                    Time = timeMovie,
                }
            );
            modelBuilder.Entity<MovieInCategory>().HasData(
                new MovieInCategory()
                {
                   MCategory_id = 1,
                   Movie_id =1,
                },
                new MovieInCategory()
                {
                    MCategory_id = 3,
                    Movie_id = 2,
                },
                new MovieInCategory()
                {
                    MCategory_id = 4,
                    Movie_id = 2,
                }
            );
            modelBuilder.Entity<Cinema>().HasData(
                new Cinema()
                {
                    Id = 1,
                    Create_at = aDateTime.Date,
                    watching_date = aDateTime.Add(timeBorrowRoom).Date,
                    RegistrationNumber = 1,
                    RegistrationLimit = 35,
                    Status = eCinemaStatus.allowed,
                    Movie_id = 2 ,
                }
            );
            modelBuilder.Entity<Registration>().HasData(
                new Registration()
                {
                    Id= 1,
                    Registration_date = aDateTime.Date,
                    Status = eRegistrationStatus.partake,
                    Cinema_id =1 ,
                }
            );
            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            // any guid, but nothing is against to use the same one
            const string ROLE_ID = ADMIN_ID;
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = new Guid(ROLE_ID),
                Name = "admin",
                NormalizedName = "admin",
                Discription = "được phép thay đổi và chỉnh sửa mọi tài nguyên hệ thống"
            }) ;

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = new Guid(ADMIN_ID),
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "quangthanhn485@gmail.com",
                NormalizedEmail = "quangthanhn485@gmail.com",
                EmailConfirmed = true,
                PhoneNumber ="0373045581",
                PasswordHash = hasher.HashPassword(null, "quangthanh123"),
                SecurityStamp = string.Empty,
                Majors ="công nghệ thông tin",
                status = eUserStatus.allowed,
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = new Guid(ROLE_ID),
                UserId = new Guid(ADMIN_ID),
            });
        }
    }
}