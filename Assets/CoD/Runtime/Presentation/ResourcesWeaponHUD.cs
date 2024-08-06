using CoD.Runtime.ViewAbstractions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CoD.Runtime.View
{
    public class ResourcesWeaponHUD : MonoBehaviour, WeaponHUD
    {
        public void Refresh(string id, int currentAmmo, int maxAmmo)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>($"{id}");
            GetComponentInChildren<TMP_Text>().text = $"{currentAmmo}/{maxAmmo}";
        }
    }
}