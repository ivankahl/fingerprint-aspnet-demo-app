# Fingerprint in ASP.NET

This is a demo ASP.NET application which shows how simple it is to integrate [Fingerprint](https://fingerprint.com/) in the registration flow of an ASP.NET application to prevent users from registering for multiple accounts from the same device.

This article accompanies an article in the Fingerprint blog.

## Getting Started

To run this demo:

1. Clone the repository
2. Create a Secret API Key in Fingerprint and paste it in the `FingerprintApiKey` property in the `appsettings.json` file.
3. Update the public API Key in the JavaScript snippet in the `Register.cshtml` file.