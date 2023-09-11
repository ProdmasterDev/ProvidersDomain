using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;

namespace ProvidersDomain.Extensions.TagHelpers
{
    [HtmlTargetElement("*", Attributes = "for-controller")]
    public class CurrentRouteTagHelper : TagHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CurrentRouteTagHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        [HtmlAttributeName("for-controller")]
        public string ControllerName { get; set; }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await base.ProcessAsync(context, output);

            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext != null)
            {
                var routeValues = httpContext.GetRouteData().Values;
                //var routeValues = httpContext.Request.RouteValues;

                if (routeValues.ContainsKey("controller"))
                    if (ControllerName != (string)routeValues["controller"])
                        output.SuppressOutput();

            }
        }
    }
}
