using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Handler : MonoBehaviour {

    public GameObject portal;

    // Update is called once per frame
    void Update () {
        RotateObj();
	}

    void RotateObj()
    {
        portal.transform.Rotate(new Vector3(0, 0, 5));
    }

}
