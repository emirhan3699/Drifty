using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    Text healthh;
   static public int health = 3;
   public int NumOfHearts = 3;
   public Sprite fullHearts;

    private void Start()
    {
        healthh = GetComponent<Text>();
        health = NumOfHearts;
    }
    void Update()
    {
        if(health > NumOfHearts)
        {
            health = NumOfHearts;
        }
        healthh.text = ":" + health;
    }
}
