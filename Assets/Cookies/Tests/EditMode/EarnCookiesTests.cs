using NUnit.Framework;

public class EarnCookiesTests
{
    [Test]
    public void Cookies_AreAddedToTheBox()
    {
        var box = new CookieBox();
        // var sut = new EarnCookies(box, new DummyCookieCounter());

        // sut.Run();
        
        Assert.AreEqual(box.CookiesPerTime, box.Cookies);
    }
}