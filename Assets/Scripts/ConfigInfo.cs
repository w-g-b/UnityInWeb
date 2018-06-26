using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ConfigInfo
{
    public int bannerCount;
    public string[] bannerSpritePaths;

    private static ConfigInfo _instance;
    private Sprite[] bannerSprites;

    public static ConfigInfo Instance
    {
        get { return _instance; }
        set
        {
            _instance = value;
            _instance.UpdateSprite();
        }
    }

    private void UpdateSprite()
    {
        bannerSprites = new Sprite[_instance.bannerCount];
        for (int i = 0; i < bannerCount; i++)
        {
            Texture2D texture2D = Resources.Load<Texture2D>(bannerSpritePaths[i]);
            bannerSprites[i] = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height),
                Vector2.zero);
        }
    }

    public Sprite getBannerSprite(int i)
    {
        if (i < 0 || i >= bannerCount)
        {
            Debug.Log("图片不存在");
            return bannerSprites[0];
        }
        else
        {
            return bannerSprites[i];
        }
    }
}