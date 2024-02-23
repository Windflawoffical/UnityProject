using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for1sphere : MonoBehaviour
{

    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * Time.deltaTime * Speed);
    }
}
