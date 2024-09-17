using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginProjectInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HostInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BandWidth = table.Column<long>(type: "bigint", nullable: true),
                    OnlineSpace = table.Column<int>(type: "int", nullable: true),
                    Support = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LatestNews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsTextSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LatestNews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReasonChoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReasonChoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLocal",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLocal", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAnonymous = table.Column<bool>(type: "bit", nullable: false),
                    LastActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthCertificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DegreeCode = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(249)", maxLength: 249, nullable: true),
                    Confirmer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmerTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    WorkHouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankReceiptNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrintCardCount = table.Column<int>(type: "int", nullable: true),
                    ConfirmerAddress = table.Column<string>(type: "nvarchar(249)", maxLength: 249, nullable: true),
                    NonIranian = table.Column<bool>(type: "bit", nullable: true),
                    RFIDCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserCode = table.Column<long>(type: "bigint", nullable: true),
                    OrgId = table.Column<long>(type: "bigint", nullable: false),
                    MembershipTypeId = table.Column<int>(type: "int", nullable: true),
                    JobCode = table.Column<int>(type: "int", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhysicalStatus = table.Column<int>(type: "int", nullable: true),
                    CreatorUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsEmailVerified = table.Column<bool>(type: "bit", nullable: false),
                    IsMembershipValid = table.Column<bool>(type: "bit", nullable: true),
                    MTAttachments_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseridConfirmer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FlagConfirmer = table.Column<bool>(type: "bit", nullable: true),
                    MaritalStatus = table.Column<int>(type: "int", nullable: true),
                    FieldStudy = table.Column<int>(type: "int", nullable: true),
                    Mobileconfirmer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favorite1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favorite2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favorite3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEndDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    IsLockedOut = table.Column<bool>(type: "bit", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: true),
                    MemberType = table.Column<int>(type: "int", nullable: true),
                    FailedPasswordAttemptCount = table.Column<int>(type: "int", nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    IsMobileVerified = table.Column<bool>(type: "bit", nullable: false),
                    UserRegisterNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HostInfo");

            migrationBuilder.DropTable(
                name: "LatestNews");

            migrationBuilder.DropTable(
                name: "ReasonChoices");

            migrationBuilder.DropTable(
                name: "UserLocal");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
