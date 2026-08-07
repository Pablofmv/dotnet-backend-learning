public class Link
{
    public Guid Id {get; set;}

    public string Subdomain {get; set;}

    public string DestinationUrl {get;set;}

    public Link(Guid id, string subdomain, string destinationUrl)
    {
        this.Id = id;
        this.Subdomain = subdomain;
        this.DestinationUrl = destinationUrl;
    }

    public string GetShortUrl() 
    {
        return $"https://myapp.com/{Subdomain}";
    }

    public static bool IsValidUrl(string url)
    {
        return url.StartsWith("https://");
    }
}