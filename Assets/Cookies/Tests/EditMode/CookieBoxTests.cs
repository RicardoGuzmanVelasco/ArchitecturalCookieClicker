using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

public class CookieBoxTests
{
    [Test]
    public void AddCookies()
    {
        var cookieBox = new CookieBox();
        cookieBox.Add(10);
        Assert.AreEqual(10, cookieBox.Cookies);
    }
}
