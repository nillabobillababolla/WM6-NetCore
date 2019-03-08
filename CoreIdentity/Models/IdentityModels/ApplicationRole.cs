using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CoreIdentity.Models.IdentityModels
{
    public class ApplicationRole : IdentityRole
    {
        [Required, StringLength(128)]
        public string Description { get; set; }
    }
}
