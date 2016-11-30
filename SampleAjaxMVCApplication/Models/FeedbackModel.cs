using System.ComponentModel.DataAnnotations;

namespace SampleAjaxMVCApplication.Models
{
    public class FeedbackModel
    {
        [Required]
        [Display(Name = "Имя пользователя")]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Адрес электронной почты")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$",
                        ErrorMessage = "Неверный формат электронной почты")]
        public string Email { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Сообщение")]
        public string MessageText { get; set; }
    }
}