using Cookies.Runtime.Application;
using NSubstitute;
using NUnit.Framework;

public class EarnCookiesTests
{
    [Test]
    public void Cookies_AreAddedToTheBox()
    {
        var box = new CookieBox();
        var sut = new EarnCookies(box, new DummyCookieCounter());

        sut.Run();
        
        Assert.AreEqual(box.CookiesPerTime, box.Cookies);
    }
    
    [Test]
    public void Cookies_AreAddedToTheCounter()
    {
        var box = new CookieBox(capacity:20394893);
        var mock = Substitute.For<CookieCounter>();
        var sut = new EarnCookies(box, mock);

        sut.Run();
        
        mock.Received().Print(box.Cookies);
    }
}