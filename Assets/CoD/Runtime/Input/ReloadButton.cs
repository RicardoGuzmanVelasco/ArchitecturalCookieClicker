using System;
using CoD.Runtime.Controller;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace CoD.Runtime.Input
{
    public class ReloadButton : MonoBehaviour
    {
        [Inject] Reload reload;

        void Awake()
        {
            GetComponent<Button>().onClick.AddListener(OnClick);
        }

        void OnClick()
        {
            reload.Run();
        }
    }
}