using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QForm.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; }
        public string ResponseMessage { get; set; }

        public void OnGet()
        {
            ResponseMessage = "アンケートにご協力ください。";
        }

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(UserName))
            {
                ResponseMessage = $"{UserName}さん、回答ありがとうございました。";
            }
            else
            {
                ResponseMessage = "入力なし";
            }
        }
    }
}
