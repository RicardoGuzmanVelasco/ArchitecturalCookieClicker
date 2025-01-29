using NUnit.Framework;

public class CookieBoxTests
{
    [Test]
    public void AddCookies()
    {
        var cookieBox = new CookieBox();
        cookieBox.Add(10);
        Assert.AreEqual(10, cookieBox.Cookies);
    }
    
    [Test]
    public void SubtractCookies()
    {
        var cookieBox = new CookieBox();
        cookieBox.Add(10);
        cookieBox.Subtract(5);
        Assert.AreEqual(5, cookieBox.Cookies);
    }
    
    [Test]
    public void DoubleMultiplicator()
    {
        var cookieBox = new CookieBox();
        cookieBox.DoubleMultiplicator();
        Assert.AreEqual(2, cookieBox.CookiesPerTime);
    }
    
    [Test]
    public void IsAffordable_OnlyIfCookiesAreGreater()
    {
        var sut = new CookieBox();
        sut.Add(10);

        Assert.That(sut.IsAffordable(5), Is.True);
        Assert.That(sut.IsAffordable(15), Is.False);
    }

    [Test]
    public void ByDefault_IsEmpty()
    {
        var cookieBox = new CookieBox();
        Assert.AreEqual(0, cookieBox.Cookies);
    }

    [Test]
    public void Capacity_Is20ByDefault()
    {
        var sut = new CookieBox();
        sut.Add(50);
        
        Assert.AreEqual(20, sut.Cookies);
    }
    
    [Test]
    public void Capacity_IsCustomizable()
    {
        var sut = new CookieBox(10);
        sut.Add(50);
        
        Assert.AreEqual(10, sut.Cookies);
    }
}
