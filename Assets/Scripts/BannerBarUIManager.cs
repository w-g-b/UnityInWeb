using System.Runtime.InteropServices;
using UnityEngine;

public class BannerBarUIManager : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void AddButton();

    void Start()
    {
        AddButton();
    }
}