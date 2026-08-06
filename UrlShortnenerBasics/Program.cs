const int MaximumSubdomainLength = 63;

Guid linkId = Guid.NewGuid();
string subdomain = "git";
string destinationUrl = "https://github.com";
long  totalClicks = 1250;
bool isActive = true;
DateTime createdAt = DateTime.UtcNow;

string shortUrl = BuildShortUrl(subdomain);

Console.WriteLine("URL Shortener");
Console.WriteLine("-----");
Console.WriteLine($"Link ID : {linkId}");
Console.WriteLine($"Subdomain : {subdomain}");
Console.WriteLine($"Short URL : {shortUrl}");
Console.WriteLine($"Destination : {destinationUrl}");
Console.WriteLine($"Total clicks : {totalClicks}");
Console.WriteLine($"Active : {isActive}");
Console.WriteLine($"Created at : {createdAt}");
Console.WriteLine($"Maximum subdomain length: {MaximumSubdomainLength}");

RecordClick(subdomain);

bool validSubdomain = isValidSubdomain(subdomain);
Console.WriteLine($"Valid Subdomain: {validSubdomain}");

string BuildShortUrl(string linkSubdomain)
{
    return $"https://{linkSubdomain}.pablomendoza.site";
}

void RecordClick(string linkSubdomain)
{
    Console.WriteLine($"Click recorded for: {linkSubdomain}");
}

bool isValidSubdomain(string linkSubdomain)
{
    return linkSubdomain.Length > 0 && linkSubdomain.Length <= MaximumSubdomainLength;
}