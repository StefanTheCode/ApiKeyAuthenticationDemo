using Microsoft.AspNetCore.Mvc;

namespace ApiKeyAuthentication.Authentication;

public class ApiKeyAttribute : ServiceFilterAttribute
{
    public ApiKeyAttribute()
        : base(typeof(ApiKeyAuthorizationFilter))
    {
    }
}