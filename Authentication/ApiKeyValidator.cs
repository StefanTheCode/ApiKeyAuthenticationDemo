namespace ApiKeyAuthentication.Authentication;

public class ApiKeyValidator : IApiKeyValidator
{
    public bool IsValid(string apiKey)
    {
        return false;
    }
}

public interface IApiKeyValidator
{
    bool IsValid(string apiKey);
}