using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGen2 : MonoBehaviour
{
    public Transform StartPos;
    float nextStep=0;
    public GameObject[] PrefabsRoad;

    timer sureTakip;

    void Awake()
    {
        Application.targetFrameRate = 60;
        sureTakip = FindObjectOfType<timer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag== "Player")
        {
          nextStep += 65.2f;
            if (sureTakip.GetTime() >= 150)
            {
                Instantiate(PrefabsRoad[Random.Range(0,2)], new Vector3(StartPos.position.x, StartPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            }
            else if(sureTakip.GetTime() >= 120)
            { 
            Instantiate(PrefabsRoad[Random.Range(0,4)], new Vector3(StartPos.position.x, StartPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            }
            else if(sureTakip.GetTime() >= 90)
            {
               
            Instantiate(PrefabsRoad[Random.Range(2,4)], new Vector3(StartPos.position.x, StartPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            }
            else if(sureTakip.GetTime() >= 60)
            {
                
            Instantiate(PrefabsRoad[Random.Range(2,5)], new Vector3(StartPos.position.x, StartPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            }
           else if (sureTakip.GetTime() >= 30)
            {
                
            Instantiate(PrefabsRoad[Random.Range(3,5)], new Vector3(StartPos.position.x, StartPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            }
            else if (sureTakip.GetTime() >= 0)
            {
            
            Instantiate(PrefabsRoad[Random.Range(5,7)], new Vector3(StartPos.position.x, StartPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            }
        }

    }
}
