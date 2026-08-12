List<string> subdomains = new List<string>();

subdomains.Add("git");
subdomains.Add("me");
subdomains.Add("info");

Console.WriteLine("Available Subdomains");

foreach (string subdomain in subdomains)
{
    Console.WriteLine(subdomain);
}

Dictionary<string, string> destinations = new Dictionary<string,string>();

destinations.Add("git","https://github.com");
destinations.Add("me","https://pablomendoza.site");
destinations.Add("info","https://example.com");

string requestedSubdomain = "youtube";

if (destinations.TryGetValue(requestedSubdomain, out string? destination))
{
    Console.WriteLine($"Redirecting {requestedSubdomain} to:");
    Console.WriteLine(destination);
} 
else
{
    Console.WriteLine("Subdomain not found");
}