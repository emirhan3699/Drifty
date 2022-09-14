using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killer : MonoBehaviour
{
    public Transform spawner;
    SmoothCameraFollow x;
    private void OnTriggerEnter(Collider other)
    {

        if (Health.health > 0)
        { 
            Health.health -= 1;
            GameObject.FindGameObjectWithTag("car").transform.position = spawner.position;
            GameObject.FindGameObjectWithTag("car").transform.rotation = spawner.rotation;
            Move.MoveForce = transform.forward * 0;
            x = GameObject.FindGameObjectWithTag("cam").GetComponent<SmoothCameraFollow>();
            x.Reset();
            
        }
        if(Health.health ==  0)
        {
            
            Destroy(GameObject.FindGameObjectWithTag("car"));
            SceneManager.LoadScene(1);
        }
    }    
}

