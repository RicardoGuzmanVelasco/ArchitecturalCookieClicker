using Cookies.Runtime.Application;
using UnityEngine;
using UnityEngine.UI;

public class PurchasePowerupButton : MonoBehaviour
{
    PurchasePowerup controller;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(CallController);
    }

    private void CallController()
    {
        controller.Run();
    }

    public void Inject(PurchasePowerup _controller)
    {
        controller = _controller;
    }
}
