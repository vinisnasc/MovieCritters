using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MovieCritters.MVC.Extensions
{
    public class RatingTagHelper : TagHelper
    {
        public double RateNote { get; set; } 
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "p";
            var conteudo = "";
            int num = 0;

            for (int i = 0; i < RateNote; i++)
            {
                conteudo += @"<span class = ""fa fa-star checked""></span>";
                num++;
            }

            while (num < 5)
            {
                conteudo += @"<span class = ""fa fa-star unchecked""></span>";
                num++;
            }

            output.Content.SetHtmlContent(conteudo);
        }
    }
}
