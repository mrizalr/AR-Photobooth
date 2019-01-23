using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objhandler : MonoBehaviour {

    public GameObject popoAR;
    private bool rotateLeft, rotateRight, zoomIn, zoomOut;

    void Update()
    {
        if (rotateLeft)
        {
            popoAR.transform.Rotate(Vector3.up * 10);
        }
        else if(rotateRight)
        {
            popoAR.transform.Rotate(Vector3.up * -10);
        }

        if (zoomIn)
        {
            popoAR.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }
        else if (zoomOut)
        {
            popoAR.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }
        rotateRight = rotateLeft = zoomIn = zoomOut = false;
    }

	public void onClickRotateLeft()
    {
        rotateLeft = true;
    }

    public void onClickRotateRight()
    {
        rotateRight = true;
    }

    public void onClickZoomIn()
    {
        zoomIn = true;
    }

    public void onClickZoomOut()
    {
        zoomOut = true;
    }
}
