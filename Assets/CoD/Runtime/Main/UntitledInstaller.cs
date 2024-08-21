using CoD.Runtime.Controller;
using CoD.Runtime.Model;
using CoD.Runtime.Presentation;
using CoD.Runtime.ViewAbstractions;
using UnityEngine;
using Zenject;

public class UntitledInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<WeaponHUD>().To<ResourcesWeaponHUD>().FromComponentsInHierarchy().AsSingle();
        Container.Bind<NoBulletsFeedback>().To<NoBulletsVisualEffect>().FromComponentsInHierarchy().AsSingle();
        
        Container.Bind<Shoot>().FromNew().AsSingle();
        Container.Bind<ToggleWeapon>().FromNew().AsSingle();
        
        Container.Bind<Equipment>().FromInstance(Equipment.Default()).AsSingle();
    }
}