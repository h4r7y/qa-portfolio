namespace automation;

using Microsoft.Playwright.NUnit; 
using NUnit.Framework;

public class LoginTest : PageTest
{
    [Test]
    public async Task TestLogin()
    {
        await Page.GotoAsync("https://www.saucedemo.com");
        await Page.FillAsync("#user-name", "standard_user");
        await Page.FillAsync("#password", "secret_sauce");
        await Page.ClickAsync("#login-button");

        Assert.That(Page.Url, Does.Contain("inventory"));
    }
}


