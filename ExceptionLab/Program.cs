Dictionary <string, string> links = new()
{
    {"unknown", "https://github.com"},
    {"me","https://pablomendoza.site"}
};

try {
    string? destination = FindDestination("", links);

    if (destination != null) 
    {
        Console.WriteLine($"Redirect to = {destination}");
    }
    else 
    {
        Console.WriteLine("404 - Link Not Found");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Invalid Request: {ex.Message}");
}

static string? FindDestination(string subdomain, Dictionary<string, string> links)
{
    if (string.IsNullOrWhiteSpace(subdomain)) 
    {
        throw new ArgumentException("Subdomain can't be empty");
    }

    if (links.TryGetValue(subdomain, out string? destination))
    {
        return destination;
    }

    return null;
}
