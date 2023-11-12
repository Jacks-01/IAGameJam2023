using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MyGameUI : MonoBehaviour
{
    public TMP_Text text;
    public static double score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0.0;
	text.text = "Score: " + score.ToString();
    }

    public void Update() {
	text.text = "Score: " + score.ToString();
    }
}
