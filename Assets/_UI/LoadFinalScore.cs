using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadFinalScore : MonoBehaviour
{
    public Text FinalScoreText;
    // Start is called before the first frame update
    void Start()
    {
        FinalScoreText.text = "Final Score: " + GameManager.Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
