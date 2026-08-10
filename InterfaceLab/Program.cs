IRedirectService redirectService = new RedirectService();

string subdomain = "git";

string destination = redirectService.GetDestination(subdomain);

Console.WriteLine($"Subdomain: {subdomain}");
Console.WriteLine($"Destination: {destination}");


