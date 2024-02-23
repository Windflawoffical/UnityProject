using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            Application.LoadLevel("pr10_first");
        }

        if(Input.GetKeyDown(KeyCode.R)){
            Application.LoadLevel("pr10_second");
        }
    }
}
