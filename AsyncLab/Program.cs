var links = new Dictionary<string, string>{
    {"git","https://github.com"},
    {"me","https://example.com"}
};


try {
    string? destination = await FindDestinationAsync("",links);

    if (destination is null)
    {
        Console.WriteLine($"404 Not Found");
        return;
    }

    Console.WriteLine($"302 Redirect -> {destination}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"400 Bad Request -> {ex.Message}");
}



static async Task<string> FindDestinationAsync(
    string subdomain,
    Dictionary <string, string> links)
{
    if (string.IsNullOrWhiteSpace(subdomain))
    {
        throw new ArgumentException("subdomain cannot be empty");
    }

    await Task.Delay(500);

    if (links.TryGetValue(subdomain, out string? destination))
    {
        return destination;
    }

    return null;
}