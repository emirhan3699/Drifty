using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    Text HgScore;
    // Start is called before the first frame update
    void Start()
    {
        HgScore = GetComponent<Text>();
        HgScore.text = PlayerPrefs.GetInt("Score").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
