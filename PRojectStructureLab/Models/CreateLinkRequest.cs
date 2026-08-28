namespace ProjectStructureLab.Models;

public class CreateLinkRequest 
{
    public string Subdomain {get; set;} = "";
    public string DestinationUrl {get; set;} = "";
}