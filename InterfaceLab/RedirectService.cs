public class RedirectService: IRedirectService
{
    public string GetDestination(string subdomain)
    {
        if (subdomain == "git")
        {
            return "https://github.com";
        }

        return "Not Found";
    }
}