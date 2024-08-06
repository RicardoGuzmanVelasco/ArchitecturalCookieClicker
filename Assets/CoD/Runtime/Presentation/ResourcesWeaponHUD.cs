using System.Linq;
using CoD.Runtime.ViewAbstractions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CoD.Runtime.View
{
    public class ResourcesWeaponHUD : MonoBehaviour, WeaponHUD
    {
        public void Refresh(string id, int currentAmmo, int maxAmmo, int remainingMagazines)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>($"{id}");
            GetComponentsInChildren<TMP_Text>().First().text = $"{currentAmmo}/{maxAmmo}";
            GetComponentsInChildren<TMP_Text>().Last().text = $"x{remainingMagazines}";
        }
    }
}