namespace ProjectStructureLab.Services;

public class LinkService: ILinkService
{
    public string? GetDestination(string subdomain)
    {
        if (subdomain == "git")
        {
            return "https://github.com";
        }

        return null;
    }
}