using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailManagement.Model
{
    public enum Roles
    {
        SuperAdmin,
        Administrator,
        User,
        Manager,
        Staff
    }

    public static class UserRoles
    {
        public const string SuperAdmin = "SuperAdmin";
        public const string Admin = "Admin";
        public const string User = "User";
        public const string Manager = "Manager";
        public const string Staff = "Staff";
    }

    public class UserProfile
    {
        public Guid UserProfileId { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 8)]
        public string Password { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 8)]
        public string ConfirmPassword { get; set; }
        public Roles Role { get; set; }
       
    }
}
