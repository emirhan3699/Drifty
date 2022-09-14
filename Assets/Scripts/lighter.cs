using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighter : MonoBehaviour
{
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("lighter"))
        {
            GameObject.FindGameObjectWithTag("lighter").SetActive(false);
        }
        else
        {
            GameObject.FindGameObjectWithTag("lighter").SetActive(true);
        }
    }
}
