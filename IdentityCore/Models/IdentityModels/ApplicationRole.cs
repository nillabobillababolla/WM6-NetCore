using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityCore.Models.IdentityModels
{
    public class ApplicationRole : IdentityRole
    {
        [StringLength(50)]
        public string Description { get; set; }
    }
}