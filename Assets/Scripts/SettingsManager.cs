using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{

    public static string playernamestri;

    public Text playername;

    // Start is called before the first frame update
    void Start()
    {
        playername.text = playernamestri;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
