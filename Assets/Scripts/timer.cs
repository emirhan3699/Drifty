using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    int kalanSure = 180;
    Text time;
    // Start is called before the first frame update
    void Start()
    {
        time = GetComponent<Text>();
        StartCoroutine(Counter());
    }

    // Update is called once per frame

    IEnumerator Counter()
    {   
        while (kalanSure > 0)
        {
            yield return new WaitForSeconds(1);
            kalanSure--;
        }
        if(kalanSure == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
    void Update()
    {
        time.text = "Time:" + kalanSure;
    }

    public int GetTime()
    {
        return kalanSure;
    }

}
