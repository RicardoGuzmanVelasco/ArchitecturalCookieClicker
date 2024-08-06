using System.Linq;
using CoD.Runtime.Model;
using CoD.Runtime.ViewAbstractions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CoD.Runtime.View
{
    public class ResourcesWeaponHUD : MonoBehaviour, WeaponHUD
    {
        public void Refresh(Weapon equippedWeapon)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>($"{equippedWeapon.Id}");
            GetComponentsInChildren<TMP_Text>().First().text = $"{equippedWeapon.CurrentMagazine.Ammo}/{equippedWeapon.CurrentMagazine.Capacity}";
            GetComponentsInChildren<TMP_Text>().Last().text = $"x{equippedWeapon.RemainingMagazines}";
        }
    }
}