using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for4cube : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y)){
            Debug.Log(name);
            Debug.Log(transform.position);
        }
    }
}
