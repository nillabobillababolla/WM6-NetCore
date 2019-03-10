using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityCore.Models.IdentityModels
{
    public class ApplicationRole : IdentityRole
    {
        [StringLength(40)]
        public string Description { get; set; }
    }
}
