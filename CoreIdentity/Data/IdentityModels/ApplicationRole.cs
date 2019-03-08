using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CoreIdentity.Data.IdentityModels
{
    public class ApplicationRole : IdentityRole
    {
        [StringLength(50)]
        public string Description { get; set; }
    }
}
