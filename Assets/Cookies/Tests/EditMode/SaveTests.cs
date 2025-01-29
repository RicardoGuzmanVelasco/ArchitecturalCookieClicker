using Cookies.Runtime.Application;
using NSubstitute;
using NUnit.Framework;

public class SaveTests
{
    [Test]
    public void SavesToTheRepo()
    {
        var repo = Substitute.For<Repo>();
        var cookieBox = new CookieBox();
        var powerUp = new PowerUp();
        var save = new Save(repo, cookieBox, powerUp);
        
        save.Run();
        
        repo.Received().Commit(cookieBox.Cookies);
    }
}