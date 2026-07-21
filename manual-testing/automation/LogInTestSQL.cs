namespace automation;

using Microsoft.Playwright.NUnit;

public class LoginTestSQL : PageTest
{
    private readonly DatabaseHelper _databaseHelper;

    public LoginTestSQL()
    {
        _databaseHelper = new DatabaseHelper();
    }

    [Test]
    public async Task Login_With_Database_Check()
    {
        await Page.GotoAsync("http://127.0.0.1:5500/login.html");

        await Page.FillAsync("#email", "test@test.com");
        await Page.FillAsync("#password", "1234");

        await Page.ClickAsync("#login");

        await Expect(Page.Locator("#message")).ToHaveTextAsync("Login successful");

        var database = new DatabaseHelper();
        var lastLogin = database.GetLastLogin("test@test.com");

        Assert.That(lastLogin, Is.Not.Null.And.Not.Empty, "Last login timestamp should not be null or empty.");
    }
}


