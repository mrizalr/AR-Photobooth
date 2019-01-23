using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class panelHandle : MonoBehaviour {

    public GameObject[] helpPanel;
    int i=0;

	// Use this for initialization
	void Start () {
        helpPanel[0].SetActive(true);
        helpPanel[1].SetActive(false);
        helpPanel[2].SetActive(false);
        helpPanel[3].SetActive(false);
        helpPanel[4].SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        for (int j = 0; j < helpPanel.Length; j++)
        {
            helpPanel[j].SetActive(false);
        }
        helpPanel[i].SetActive(true);
	}

    public void NextClick()
    {
        if (i<4)
        {
            i++;
        }
        else if (i == 4)
        {
            i = 0;
        }
    }

    public void PrevClick()
    {
        if (i > 0)
        {
            i--;
        }
        else if (i == 0)
        {
            i = 4;
        }
    }
}
