using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for2cube : MonoBehaviour
{
    public GameObject SomeGameObject;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)){
            SomeGameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
