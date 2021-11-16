using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class MenuManager : MonoBehaviour
{
    public InputField playername;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Player Name is: " + playername.text);
        SettingsManager.playernamestri = "Player: " + playername.text;
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    // tutorial for capturing player name found in this video https://www.youtube.com/watch?v=UnEDxN0DEa4


}
