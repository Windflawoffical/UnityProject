using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for1cube : MonoBehaviour
{

    public GameObject SomeGameObject;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            SomeGameObject.GetComponent<Rigidbody>().AddForce(0,150,0);
        }
    }
}
