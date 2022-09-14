using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGen : MonoBehaviour
{
    public Transform StartPos;
    int nextStep = 0;
    public GameObject[] PrefabsRoad;

    // Update is called once per frame
    private void Start()
    {
        nextStep += 40;
        
        {

          Instantiate(PrefabsRoad[Random.Range(0,2)], new Vector3(StartPos.position.x, StartPos.position.y, transform.position.z + nextStep), Quaternion.identity);
        }
    }

}
