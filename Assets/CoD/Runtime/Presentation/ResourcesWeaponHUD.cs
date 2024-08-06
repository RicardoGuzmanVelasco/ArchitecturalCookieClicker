using CoD.Runtime.Controller;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CoD.Runtime.View
{
    public class ResourcesWeaponHUD : MonoBehaviour, WeaponHUD
    {
        public void Refresh(string id)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>($"{id}");
        }
    }
}