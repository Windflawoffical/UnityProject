using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pr4 : MonoBehaviour
{

    public Transform EndPoint;

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject);
        //Destroy(collision.gameObject);
    }

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
