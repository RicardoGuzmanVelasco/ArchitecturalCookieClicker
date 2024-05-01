using Cookies.Runtime.Application;
using System;

public sealed class Save
{
    readonly Repo repo;
    readonly CookieBox cookieBox;
    readonly PowerUp powerUp;

    public Save(Repo repo, CookieBox cookieBox, PowerUp powerUp)
    {
        this.repo = repo ?? throw new ArgumentNullException(nameof(repo));
        this.cookieBox = cookieBox ?? throw new ArgumentNullException(nameof(cookieBox));
        this.powerUp = powerUp ?? throw new ArgumentNullException(nameof(powerUp));
    }
    public void Run()
    {
        repo.Commit(cookieBox.Cookies, powerUp.Level);
    }
}
