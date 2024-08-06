using CoD.Runtime.Controller;
using CoD.Runtime.ViewAbstractions;
using UnityEngine;
using UnityEngine.UI;

namespace CoD.Runtime.Input
{
    public class ToggleWeaponButton : MonoBehaviour
    {
        ToggleWeapon controller;

        void Start()
        {
            Debug.Assert(controller is not null);
            
            controller.RunForTheFirstTime();
            GetComponent<Button>().onClick.AddListener(() => controller.Run());
        }

        public void Inject(ToggleWeapon controllerToInject)
        {
            controller = controllerToInject;
        }
    }
}