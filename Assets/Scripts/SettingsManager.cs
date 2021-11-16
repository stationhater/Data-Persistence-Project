using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{

    public static string playernamestri;
    public static string topscorestri;
    public static int topscoreint;

    public Text playername;

    public Text topScore;

    // Start is called before the first frame update
    void Start()
    {
        //topscoreint = 0;
        playername.text = playernamestri;
        topScore.text = "Top Score: " + topscorestri;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
