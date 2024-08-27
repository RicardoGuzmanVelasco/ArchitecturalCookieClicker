using System.Linq;
using System.Threading.Tasks;
using CoD.Runtime.Model;
using CoD.Runtime.ViewAbstractions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CoD.Runtime.Presentation
{
    public class ResourcesWeaponHUD : MonoBehaviour, WeaponHUD
    {
        public void Refresh(Weapon equippedWeapon)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>($"{equippedWeapon.Id}");
            GetComponentsInChildren<TMP_Text>().First().text = $"{equippedWeapon.CurrentMagazine.Ammo}/{equippedWeapon.CurrentMagazine.Capacity}";
            GetComponentsInChildren<TMP_Text>().Last().text = $"x{equippedWeapon.RemainingMagazines}";
        }

        public async void WarnFull()
        {
            var textBefore = GetComponentsInChildren<TMP_Text>().First().text;
            GetComponentsInChildren<TMP_Text>().First().text = "FULL";
            await Task.Delay(500);
            GetComponentsInChildren<TMP_Text>().First().text = textBefore;
        }
        
        public async void WarnEmpty()
        {
            var textBefore = GetComponentsInChildren<TMP_Text>().First().text;
            GetComponentsInChildren<TMP_Text>().First().text = "EMPTY";
            await Task.Delay(500);
            GetComponentsInChildren<TMP_Text>().First().text = textBefore;
        }
    }
}