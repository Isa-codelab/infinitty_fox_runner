using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public TextMeshProUGUI scorenumb; // recebe o texteNumb

    private int scorecount = 0;  //0 var que acumula os scores

    public static ScoreHandler instance; //precisa para eu conseguir acessar em outro script

    void Awake()
    {
        instance = this;
    }
    public void Scoredadd(int value) //acumular os scores
    {
        scorecount += value;
        scorenumb.text = scorecount.ToString();
    }
}
