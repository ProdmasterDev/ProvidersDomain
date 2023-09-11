using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ProvidersDomain.Extensions.TagHelpers
{
    [HtmlTargetElement("*", Attributes = "asp-authorize")]
    public class AuthorizeTagHelper : TagHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthorizeTagHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        [HtmlAttributeName("asp-authorize")]
        public bool Authorize { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await base.ProcessAsync(context, output);

            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext != null)
            {
            if ((httpContext.User != null) && !httpContext.User.Identity.IsAuthenticated)
                {
                    output.SuppressOutput();
                }
            }
        }
    }
}
