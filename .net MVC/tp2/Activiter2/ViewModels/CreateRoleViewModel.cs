using System.ComponentModel.DataAnnotations;

namespace Activiter2.ViewModels
{

    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }

}
