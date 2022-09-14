using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorecounter : MonoBehaviour
{
  private void Update()
    {
        if (Move.angle > 45)
        {
            ScoreSc.scoreValue += 1;
        }
        
    }
}
