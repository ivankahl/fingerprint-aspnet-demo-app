using Microsoft.AspNetCore.Identity;

namespace FingerprintAspNetCore.Data;

public class ApplicationUser : IdentityUser
{
    public string Fingerprint { get; set; }
    public DateTime RegistrationDate { get; set; }
}