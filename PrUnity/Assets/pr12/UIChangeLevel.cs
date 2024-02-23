using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIChangeLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickSwitch()
    {
        Application.LoadLevel("pr12_second");
    }

    // Update is called once per frame
    public void OnQuitClick()
    {
        Application.Quit();
    }
}
