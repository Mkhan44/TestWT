using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items_Needed_Manager : MonoBehaviour
{
    public static bool item1Done = false;
    public static bool item2Done = false;

    GameObject objectiveUI;
    Text objectiveText;
    

    void Start()
    {
        objectiveUI = GameObject.Find("ScoreTest");
        objectiveText = objectiveUI.GetComponent<Text>();
        
    }

    void Update()
    {
        if(item1Done && item2Done)
        {
            item1Done = false;
            item2Done = false;
            objectiveText.text = "Objective: Completed!";
            Debug.Log("We have cleared the level!");
        }
    }

}
