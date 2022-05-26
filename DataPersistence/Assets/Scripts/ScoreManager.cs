using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public string currentPlayerName;
    public string topPlayerName;
    public int highScore;

    [System.Serializable]
    class SaveData
    {
        public string topPlayerName;
        public int highScore;
    }

    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.topPlayerName = topPlayerName; 
        data.highScore = highScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

        print("Score Saved!");
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            topPlayerName = data.topPlayerName;
            highScore = data.highScore;

            print("Score Loaded!");
        }
    }


    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
        LoadScore();
    }
}
