using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text kiriScore, kananScore;
    public ScoreManager manager;
    // Update is called once per frame
    private void Update()
    {
        kananScore.text = manager.leftScore.ToString();
        kiriScore.text = manager.rightScore.ToString();
    }
}
