using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameInputHandler : MonoBehaviour
{
    public GameObject inputField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inputField != null)
        {
            ScoreManager.instance.currentPlayerName = inputField.GetComponent<TMP_InputField>().text;
        }
        else
        {
            ScoreManager.instance.currentPlayerName = "null";
        }
        
    }
}
