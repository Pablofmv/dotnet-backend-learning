string subdomain = "git";
string destinationUrl = "https://github.com";

string? referrer = "https://google.com";

string source = referrer ?? "Direct";

Console.WriteLine($"Subdomain: {subdomain}");
Console.WriteLine($"Destination: {destinationUrl}");
Console.WriteLine($"Source: {source}");

int? ReferrerLength = referrer?.Length;

if (ReferrerLength != null) {
    Console.WriteLine($"Referrer Length: {ReferrerLength}");
} 
else 
{
    Console.WriteLine($"No referrer lenght available");
}
