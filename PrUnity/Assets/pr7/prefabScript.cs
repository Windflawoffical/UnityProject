using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prehabScript : MonoBehaviour
{
    public GameObject Prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            Instantiate(Prefab,transform.position,transform.rotation);
        }
    }
}
