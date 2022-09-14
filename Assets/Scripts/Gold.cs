using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public int coin;
    private void Start()
    {
        coin = 0;
    }
    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "coin")
        {
            ScoreSc.scoreValue += 50;
            coin = coin + 1;
            other.gameObject.SetActive(false);
        }
    }
}
