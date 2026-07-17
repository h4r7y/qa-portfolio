namespace automation;

using Microsoft.Playwright; 
using NUnit.Framework;

public class LoginTest
{
    [Test]
    public async Task TestLogin()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions { Headless = true });
        
        var page = await browser.NewPageAsync();

        await page.GotoAsync("https://www.saucedemo.com");
      
        await page.FillAsync("#user-name", "standard_user");
        await page.FillAsync("#password", "secret_sauce");
        await page.ClickAsync("#loginButton");
        
        Assert.That(page.Url, Does.Contain("inventory"));
    }

}
