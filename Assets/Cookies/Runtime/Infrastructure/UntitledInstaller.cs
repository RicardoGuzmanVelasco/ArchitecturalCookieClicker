using Cookies.Runtime.Application;
using UnityEngine;
using Zenject;

public class UntitledInstaller : Installer<UntitledInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<CookieBox>().AsSingle();
        Container.Bind<PowerUp>().AsSingle();

        Container.Bind<EarnCookies>().AsSingle();
        Container.Bind<PurchasePowerup>().AsSingle();

        Container.Bind<CookieCounter>().FromComponentInHierarchy().AsSingle();
        Container.Bind<CookieMultiplier>().FromComponentInHierarchy().AsSingle();
    }
}