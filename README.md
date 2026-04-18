# Credential Check Example

This is a simple ASP.NET Core Web API that demonstrates how to check credentials (username/password) on a login endpoint.

## Project Structure

- `CredentialCheckExample.csproj` - The project file
- `Controllers/AccountController.cs` - Contains the login endpoint that checks credentials
- `Program.cs` - Sets up the ASP.NET Core application

## Important Security Notes

⚠️ **This is for demonstration only!** In a real application:

1. **Never hardcode passwords** - Use secure secret management (Azure Key Vault, environment variables, etc.)
2. **Always hash passwords** - Use BCrypt, PBKDF2, or similar for password storage
3. **Use secure comparison** - To prevent timing attacks
4. **Implement proper authentication** - Use JWT tokens, cookies, or OAuth
5. **Use HTTPS** - Always in production
6. **Add rate limiting** - To prevent brute force attacks
7. **Validate input** - Use proper validation and sanitization

## How to Run

1. Install .NET 8 SDK (https://dotnet.microsoft.com/download)
2. Navigate to the project directory
3. Run: `dotnet run`
4. The API will be available at https://localhost:5001 (or http://localhost:5000)

## Example Request

POST /account/login
Content-Type: application/json

{
  "username": "admin",
  "password": "password123"
}

## Response

Success:
{
  "message": "Login successful"
}

Failure (401):
{
  "message": "Invalid username or password"
}