using CoD.Runtime.Controller;
using TMPro;
using UnityEngine;

namespace CoD.Runtime.View
{
    public class TextMeshProWeaponHUD : MonoBehaviour, WeaponHUD
    {
        public void Refresh(string id)
        {
            GetComponent<TextMeshProUGUI>().text = id;
        }
    }
}