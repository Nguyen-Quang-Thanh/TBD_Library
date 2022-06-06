using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TBD_library.Data.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categoties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogBorrowBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<int>(type: "int", nullable: false),
                    NameBook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Borrowed_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogBorrowBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogCinemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameLibarian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Watching_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    RegistrationNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogCinemas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Room_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessionTime = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Majors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShouldLock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentCode = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false, defaultValue: 3),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogRegistrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<int>(type: "int", nullable: false),
                    Registration_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LogCinema_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogRegistrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogRegistrations_LogCinemas_LogCinema_id",
                        column: x => x.LogCinema_id,
                        principalTable: "LogCinemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieInCategories",
                columns: table => new
                {
                    Movie_id = table.Column<int>(type: "int", nullable: false),
                    MCategory_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieInCategories", x => new { x.Movie_id, x.MCategory_id });
                    table.ForeignKey(
                        name: "FK_MovieInCategories_MCategories_MCategory_id",
                        column: x => x.MCategory_id,
                        principalTable: "MCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieInCategories_Movies_Movie_id",
                        column: x => x.Movie_id,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BorrowBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Borrowed_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 6, 8, 22, 20, 70, DateTimeKind.Local).AddTicks(1923)),
                    Borrowed_time = table.Column<TimeSpan>(type: "time", nullable: false),
                    GiveBack_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    User_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BorrowBooks_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Borrow_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 6, 8, 22, 20, 71, DateTimeKind.Local).AddTicks(4942)),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    ParticipantNumber = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    User_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BorrowRooms_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Create_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 6, 8, 22, 20, 72, DateTimeKind.Local).AddTicks(260)),
                    watching_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationNumber = table.Column<int>(type: "int", nullable: false),
                    RegistrationLimit = table.Column<int>(type: "int", nullable: false, defaultValue: 30),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    User_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Movie_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cinemas_Movies_Movie_id",
                        column: x => x.Movie_id,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cinemas_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 6, 8, 22, 20, 74, DateTimeKind.Local).AddTicks(6415)),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViewCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Status = table.Column<int>(type: "int", nullable: false),
                    User_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 6, 8, 22, 20, 68, DateTimeKind.Local).AddTicks(3145)),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    BorrowCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowBook_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_BorrowBooks_BorrowBook_id",
                        column: x => x.BorrowBook_id,
                        principalTable: "BorrowBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BorrowInRoom",
                columns: table => new
                {
                    Borrow_id = table.Column<int>(type: "int", nullable: false),
                    Room_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowInRoom", x => new { x.Borrow_id, x.Room_id });
                    table.ForeignKey(
                        name: "FK_BorrowInRoom_BorrowRooms_Borrow_id",
                        column: x => x.Borrow_id,
                        principalTable: "BorrowRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BorrowInRoom_Rooms_Room_id",
                        column: x => x.Room_id,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Registration_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 6, 8, 22, 20, 76, DateTimeKind.Local).AddTicks(107)),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Cinema_id = table.Column<int>(type: "int", nullable: false),
                    User_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registrations_Cinemas_Cinema_id",
                        column: x => x.Cinema_id,
                        principalTable: "Cinemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registrations_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostInCategries",
                columns: table => new
                {
                    Post_id = table.Column<int>(type: "int", nullable: false),
                    Category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostInCategries", x => new { x.Post_id, x.Category_id });
                    table.ForeignKey(
                        name: "FK_PostInCategries_Categoties_Category_id",
                        column: x => x.Category_id,
                        principalTable: "Categoties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostInCategries_Posts_Post_id",
                        column: x => x.Post_id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookInCategories",
                columns: table => new
                {
                    Book_id = table.Column<int>(type: "int", nullable: false),
                    BCategory_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookInCategories", x => new { x.Book_id, x.BCategory_id });
                    table.ForeignKey(
                        name: "FK_BookInCategories_BCategories_BCategory_id",
                        column: x => x.BCategory_id,
                        principalTable: "BCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookInCategories_Books_Book_id",
                        column: x => x.Book_id,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BCategories",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "khái phá giá trị của nền văn hóa , văn minh nhân loại", "sách văn hóa" },
                    { 2, "sách nói những gì lênh quan đến cuộc sống mọi thứ tác động đến chúng ta trong cuộc sống", "cuộc sống" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BorrowBook_id", "Created_at", "Description", "Img", "Name", "Publisher", "Slug", "Status", "Summary", "User_id" },
                values: new object[] { 2, "Adam Khoo", null, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "cuốn sách dạy ra các mẹo để có thể tối ưu tất cả những gì ta có thể làm", "toi-tai-gioi-ban-cung-the.jpg", "tôi tài giỏi bạn cũng thế", null, null, 1, "sach hay", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "BorrowBooks",
                columns: new[] { "Id", "Borrowed_date", "Borrowed_time", "GiveBack_date", "Status", "User_id" },
                values: new object[] { 1, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 0, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "BorrowRooms",
                columns: new[] { "Id", "Borrow_date", "Time", "User_id" },
                values: new object[] { 1, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 2, 30, 0, 0), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Categoties",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "những thông tin mới nhất từ thư viện luôn được cập nhật", "thông báo" });

            migrationBuilder.InsertData(
                table: "MCategories",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "mô tả các khía cạnh văn hóa xã hội", "tài liệu" },
                    { 2, "phim giải trí mang tính gây cười", "hài kịch" },
                    { 3, "phim được dựng nên bởi các nét vẽ sinh động", "anime" },
                    { 4, "thể loại phim mang tính chất kịch tính hồi hộp", "hành động" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Img", "Name", "Summary", "Time", "Trailer" },
                values: new object[,]
                {
                    { 1, null, "Quà tặng cuộc sống", "phim nói về triết lý cuộc sống", new TimeSpan(0, 2, 0, 0, 0), null },
                    { 2, null, "đại chiến chén thánh", "phim nói về cuộc chiến tranh dành chén thánh của các anh linh và master của họ", new TimeSpan(0, 2, 0, 0, 0), null }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Conten", "Created_at", "Img", "Slug", "Status", "Summary", "Title", "Updated_at", "User_id" },
                values: new object[] { 1, "dữ liệu mẫu", new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), null, null, 0, "mẫu ban đầu", "blog mẫu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discription", "Name", "NormalizedName" },
                values: new object[] { new Guid("a18be9c0-aa65-4af8-bd17-00bd9344e575"), "1d006247-c254-421b-9b55-ff1cb255a45c", "được phép thay đổi và chỉnh sửa mọi tài nguyên hệ thống", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "RoomName", "Room_date", "SessionTime", "Status" },
                values: new object[] { 1, "phòng họp 6/6/2022 12:00:00 AM", new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 1, 0 });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("a18be9c0-aa65-4af8-bd17-00bd9344e575"), new Guid("a18be9c0-aa65-4af8-bd17-00bd9344e575") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Majors", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShouldLock", "StudentCode", "TwoFactorEnabled", "UserName", "status" },
                values: new object[] { new Guid("a18be9c0-aa65-4af8-bd17-00bd9344e575"), 0, "176139f7-09da-479b-9924-ef7544af1fb1", "quangthanhn485@gmail.com", true, false, null, "công nghệ thông tin", "quangthanhn485@gmail.com", "admin", "AQAAAAEAACcQAAAAEAhgQdYPDFZcIJpSQpVc2bdOkmYq1DQSG296aytX7G8bfu2FWtk1WdyXzdMMuQsdYQ==", "0373045581", false, "", null, 0, false, "admin", 3 });

            migrationBuilder.InsertData(
                table: "BookInCategories",
                columns: new[] { "BCategory_id", "Book_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BorrowBook_id", "Created_at", "Description", "Img", "Name", "Publisher", "Slug", "Summary", "User_id" },
                values: new object[] { 1, "Blair T.Spalding", 1, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "cuốn sách hay nhất mọi thời đại khám phá nhữ giá trị vĩnh hằng", "hanh-trinh-ve-phuong-dong.jpg", "hành trình về phương đông", null, null, "sach hay", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "BorrowInRoom",
                columns: new[] { "Borrow_id", "Room_id" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Create_at", "Movie_id", "RegistrationLimit", "RegistrationNumber", "Slug", "User_id", "watching_date" },
                values: new object[] { 1, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 2, 35, 1, null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "MovieInCategories",
                columns: new[] { "MCategory_id", "Movie_id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 2 },
                    { 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "PostInCategries",
                columns: new[] { "Category_id", "Post_id" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "BookInCategories",
                columns: new[] { "BCategory_id", "Book_id" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "Cinema_id", "Registration_date", "User_id" },
                values: new object[] { 1, 1, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.CreateIndex(
                name: "IX_BookInCategories_BCategory_id",
                table: "BookInCategories",
                column: "BCategory_id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BorrowBook_id",
                table: "Books",
                column: "BorrowBook_id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_User_id",
                table: "Books",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBooks_User_id",
                table: "BorrowBooks",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowInRoom_Room_id",
                table: "BorrowInRoom",
                column: "Room_id");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowRooms_User_id",
                table: "BorrowRooms",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_Movie_id",
                table: "Cinemas",
                column: "Movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_User_id",
                table: "Cinemas",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_LogRegistrations_LogCinema_id",
                table: "LogRegistrations",
                column: "LogCinema_id");

            migrationBuilder.CreateIndex(
                name: "IX_MovieInCategories_MCategory_id",
                table: "MovieInCategories",
                column: "MCategory_id");

            migrationBuilder.CreateIndex(
                name: "IX_PostInCategries_Category_id",
                table: "PostInCategries",
                column: "Category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_User_id",
                table: "Posts",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_Cinema_id",
                table: "Registrations",
                column: "Cinema_id");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_User_id",
                table: "Registrations",
                column: "User_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookInCategories");

            migrationBuilder.DropTable(
                name: "BorrowInRoom");

            migrationBuilder.DropTable(
                name: "LogBorrowBooks");

            migrationBuilder.DropTable(
                name: "LogRegistrations");

            migrationBuilder.DropTable(
                name: "MovieInCategories");

            migrationBuilder.DropTable(
                name: "PostInCategries");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "RoleTokens");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "BCategories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "BorrowRooms");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "LogCinemas");

            migrationBuilder.DropTable(
                name: "MCategories");

            migrationBuilder.DropTable(
                name: "Categoties");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DropTable(
                name: "BorrowBooks");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
