using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour //даем системе понять, что это сетевой объект
{
    float speed = 5.0f;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical"); 

        Vector3 movement = new Vector3(horizontal, 0f, vertical); 

        GetComponent<CharacterController>().Move(movement * Time.deltaTime * speed); 
    }
}