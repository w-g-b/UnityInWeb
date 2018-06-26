using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigManager : MonoBehaviour
{
    public Image bannerImage;

    private void Awake()
    {
        var str = Resources.Load<TextAsset>("config").text;
        print(str);
        var configInfo = JsonUtility.FromJson<ConfigInfo>(str);
        print(configInfo.bannerCount);
        ConfigInfo.Instance = configInfo;
    }

    public void SetBannerImage(int i)
    {
        bannerImage.sprite = ConfigInfo.Instance.getBannerSprite(1);
    }

    private void Start()
    {
    }

    private void Update()
    {
    }
}