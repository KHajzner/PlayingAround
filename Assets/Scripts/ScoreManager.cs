using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

	public TMP_Text textScore;
	public float score;
	public TMP_Text winning;
	
    // Start is called before the first frame update
    void Start()
    {
    	score = 0f;
        textScore.text = score.ToString() + " Coins";
        winning.text = "";
        
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = score.ToString() + " Coins";
    }
}
