using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginProjectDomain.Models
{
    public class Users
    {
        [Key]
        [Display(Name = "شناسه کاربری")]
        public Guid UserId { get; set; }


        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Display(Name = "جلوگیری از ارائه خدمات")]
        public bool IsAnonymous { get; set; }

        [Display(Name = "تاریخ آخرین فعالیت")]
        public DateTime LastActivityDate { get; set; }

        [Display(Name = "نام")]
        public string? Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string? Family { get; set; }

        [Display(Name = "تاریخ تولد")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "شماره شناسنامه")]
        public string? BirthCertificationNumber { get; set; }

        [Display(Name = "کد پرسنلی")]
        public string? EmployeeNumber { get; set; }

        [Display(Name = "توضیحات")]
        public string? Description { get; set; }

        [Display(Name = "تلفن")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "مدرک")]
        public int? DegreeCode { get; set; }

        [MaxLength(249, ErrorMessage = "طول آدرس حداکثر 249کارکتر می باشد.")]
        [Display(Name = "آدرس")]
        public string? Address { get; set; }

        [Display(Name = "معرف")]
        public string? Confirmer { get; set; }

        [Display(Name = "تلفن معرف")]
        public string? ConfirmerTel { get; set; }

        [Display(Name = "کد ملی/کد خانوار")]
        public string? NationalCode { get; set; }

        [Display(Name = "جنسیت")]
        public int? Sex { get; set; }
        [Display(Name = "نام پدر")]
        public string? FatherName { get; set; }

        [Display(Name = "تلفن همراه")]
        [StringLength(11, ErrorMessage = "شماره را به صورت 09120000000 وارد کنید.", MinimumLength = 11)]
        public string? MobileNumber { get; set; }

        [Display(Name = "مدرک")]
        public string? WorkHouse { get; set; }

        [Display(Name = "شماره حساب")]
        public string? BankReceiptNumber { get; set; }
        [Display(Name = "نوع کارت")]
        public int? PrintCardCount { get; set; }
        [MaxLength(249, ErrorMessage = "طول آدرس معرف حداکثر 249کارکتر می باشد.")]
        [Display(Name = "آدرس معرف")]
        public string? ConfirmerAddress { get; set; }

        [Display(Name = "غیر ایرانی")]
        public bool? NonIranian { get; set; }

        [Display(Name = "RFID Code")]
        public string? RFIDCode { get; set; }

        [Display(Name = "آدرس تصویر")]
        public string? ImageAddress { get; set; }
        [Display(Name = "کد کاربری")]
        public long? UserCode { get; set; }
        [Display(Name = "کد واحد")]

        public long OrgId { get; set; }


        [Display(Name = "شناسه نوع عضویت")]
        public int? MembershipTypeId { get; set; }

        [Display(Name = "شناسه شغل")]
        public int? JobCode { get; set; }
        [Display(Name = "تاریخ ثبت نام")]
        [UIHint("DateTemplate")]
        public DateTime? RegisterDate { get; set; }

        [Display(Name = "وضعیت جسمانی")]
        public int? PhysicalStatus { get; set; }
        [Display(Name = "کاربر ایجاد کننده")]
        public Guid? CreatorUserId { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool? IsMembershipValid { get; set; }

        [Display(Name = "آدرس ملحقات عضویت ها")]
        public string? MTAttachments_Address { get; set; }
        public Guid? UseridConfirmer { get; set; }

        public bool? FlagConfirmer { get; set; }
        [Display(Name = "وضعیت تاهل")]
        public int? MaritalStatus { get; set; }
        [Display(Name = "رشته تحصیلی")]
        public int? FieldStudy { get; set; }

        public string? Mobileconfirmer { get; set; }
        [Display(Name = "علاقه مندی شماره یک")]
        public string? Favorite1 { get; set; }
        [Display(Name = "علاقه مندی شماره دو")]
        public string? Favorite2 { get; set; }
        [Display(Name = "علاقه مندی شماره سه")]
        public string? Favorite3 { get; set; }
        [Required]
        public Guid Id { get; set; }
        [NotMapped]
        [Display(Name = "پست الکترونیک")]
        public string? Email { get; set; }
        [Required]
        public bool EmailConfirmed { get; set; }

        public string? PasswordHash { get; set; }

        public string? SecurityStamp { get; set; }

        [Required]
        public bool PhoneNumberConfirmed { get; set; }

        [Required]
        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        [Required]
        public bool LockoutEnabled { get; set; }

        [Required]
        public int AccessFailedCount { get; set; }
        [Display(Name = "قفل شده")]
        public bool? IsLockedOut { get; set; }
        [Display(Name = "تایید ")]
        public bool? IsApproved { get; set; }

        [Display(Name = "نوع عضویت")]
        public int? MemberType { get; set; }
        [Display(Name = "تعداد رمز عبور اشتباه")]
        public int FailedPasswordAttemptCount { get; set; }
        [Display(Name = "تایید شماره موبایل")]
        public DateTime? LastLoginDate { get; set; }
        [Display(Name = "ملیت")]
        public int CountryId { get; set; }
        public bool IsMobileVerified { get; set; }
        public int? UserRegisterNumber { get; set; }

        //[Display(Name = "شغل")]
        //[ForeignKey("JobCode")]
        //public virtual UserJob UserJob { get; set; }
        //[ForeignKey("MembershipTypeId")]
        //[Display(Name = "نوع عضویت")]
        //public virtual UserMembershipType UserMembershipType { get; set; }

        //public virtual ICollection<CurrentBorrow> CurrentBorrows { get; set; }
        //public virtual ICollection<FinancialHistory> FinancialHistory { get; set; }
    }
}
