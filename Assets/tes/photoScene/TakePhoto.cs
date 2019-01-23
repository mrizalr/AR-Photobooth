using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePhoto : MonoBehaviour {

    public GameObject photoButton;
    public GameObject galeriButton;
    public GameObject _objHandler;
    public GameObject blinkEffect;

    public void TakeAShot()
    {
        StartCoroutine("CaptureIt");
    }

    IEnumerator CaptureIt()
    {
        photoButton.SetActive(false);
        galeriButton.SetActive(false);
        _objHandler.SetActive(false);
        string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
        string fileName = "Screenshot-" + timeStamp + " .png";
        string pathToSave = fileName;
        ScreenCapture.CaptureScreenshot(pathToSave);
        yield return new WaitForEndOfFrame();
        GameObject blink = Instantiate(blinkEffect, new Vector2(0f, 0f), Quaternion.identity) as GameObject;
        blink.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        Destroy(blink, 2f);
        photoButton.SetActive(true);
        galeriButton.SetActive(true);
        _objHandler.SetActive(true);
    }
    
}
