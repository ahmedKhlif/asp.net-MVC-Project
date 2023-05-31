using System.ComponentModel.DataAnnotations;

namespace Activiter2.ViewModels
{
    public class EditViewModel:CreateViewModel
    {
        public int Id { get; set; }
        public string ExistingImagePath { get; set; }
    }
}
