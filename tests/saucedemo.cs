using Microsoft.Playwright.MSTest;
using Microsoft.Playwright;

[TestClass]
public class Tests : PageTest
{
    [TestMethod]
    public async Task MyTest()
    {
        await Page.GotoAsync("https://www.saucedemo.com/");
        await Page.Locator("[data-test=\"username\"]").ClickAsync();
        await Page.Locator("[data-test=\"username\"]").FillAsync("standard_user");
        await Page.Locator("[data-test=\"password\"]").ClickAsync();
        await Page.Locator("[data-test=\"password\"]").FillAsync("secret_sauce");
        await Page.Locator("[data-test=\"login-button\"]").ClickAsync();
        await Page.Locator("[data-test=\"item-1-img-link\"]").ClickAsync();
        await Page.Locator("[data-test=\"add-to-cart\"]").ClickAsync();
        await Page.Locator("[data-test=\"shopping-cart-link\"]").ClickAsync();
        await Page.Locator("[data-test=\"checkout\"]").ClickAsync();
        await Page.Locator("[data-test=\"firstName\"]").ClickAsync();
        await Page.Locator("[data-test=\"firstName\"]").FillAsync("Nsikak-Abasi");
        await Page.Locator("[data-test=\"lastName\"]").ClickAsync();
        await Page.Locator("[data-test=\"lastName\"]").FillAsync("Udoh");
        await Page.Locator("[data-test=\"postalCode\"]").ClickAsync();
        await Page.Locator("[data-test=\"postalCode\"]").FillAsync("520101");
        await Page.Locator("[data-test=\"continue\"]").ClickAsync();
        await Page.Locator("[data-test=\"finish\"]").ClickAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Open Menu" }).ClickAsync();
        await Page.Locator("[data-test=\"logout-sidebar-link\"]").ClickAsync();
    }
}
