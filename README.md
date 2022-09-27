## DOCS
```csharp
//init client
KopeechkaClient client = new KopeechkaClient("APIKEY HERE");
 
//gen new email GenerateEmail(string site, string mail_type, string sender, string regex, string soft, string investor, string subject, string clear)
var email = await client.GenerateEmail();

// Current functions
GenerateEmail
GetMessageOfMail
GetBalance
GenerateEmail
```

## Nuget
```csharp
Install-Package Kopeechka.API 
```
