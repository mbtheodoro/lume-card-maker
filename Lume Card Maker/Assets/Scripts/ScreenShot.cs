using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
    public PanelSelector panelSelector;

    //private 
    private bool takeScreenShot;

    public IEnumerator TakeScreenShot()
    {
        yield return new WaitForEndOfFrame();

        RectTransform rectT = panelSelector.GetActiveCard();

        Vector2 temp = rectT.transform.position;
        int width = System.Convert.ToInt32(rectT.rect.width);
        int height = System.Convert.ToInt32(rectT.rect.height);
        int startX = (int) temp.x - width / 2;
        int startY = (int) temp.y - height / 2;

        Texture2D tex = new Texture2D(width, height, TextureFormat.RGB24, false);
        tex.ReadPixels(new Rect(startX, startY, width, height), 0, 0);
        tex.Apply();

        SaveCardImage(tex.EncodeToPNG());

        Destroy(tex);
    }

    private void SaveCardImage(byte[] imageData)
    {
        string path;
        //Directory
        if (Application.isEditor)
            path = "C:\\Users\\Murilo\\Desktop\\test\\";
        else
        {
            path = System.IO.Path.Combine(Application.dataPath, "CardImages");
            System.IO.Directory.CreateDirectory(path);
        }

        //File
        DateTime date = DateTime.Now;
        string filename = date.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";

        //Save Image
        System.IO.File.WriteAllBytes(System.IO.Path.Combine(path, filename), imageData);

        Debug.Log("Saved Screenshot:");
        Debug.Log("--Folder: " + path);
        Debug.Log("----File: " + filename);
    }

    public void MyOnClick()
    {
        StartCoroutine(TakeScreenShot());
    }
}
