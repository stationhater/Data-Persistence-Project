using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

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

    [System.Serializable]
    class SaveData
    {
        public int savedScore;       
    }

    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.savedScore = SettingsManager.topscoreint;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefil.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            topscoreint = data.savedScore;
        }

    }
}
