using UnityEngine.UI;
using UnityEngine;

public class SaveButton : MonoBehaviour
{
    readonly Save controller;
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(CallController);
    }

    private void CallController()
    {
        controller.Run();
    }
}
