using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pr3 : MonoBehaviour
{
    public Transform EndPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, EndPoint.position, Time.deltaTime);
    }
}
