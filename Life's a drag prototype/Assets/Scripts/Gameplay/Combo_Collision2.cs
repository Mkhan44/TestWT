using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo_Collision2 : MonoBehaviour
{

    static public string tagToCompare = "";
    bool collided = false;
    int counter = 0;

    GameObject itemNeeded1;
    GameObject comboItemNeeded1;

    void Start()
    {
        //Find the items in the UI. We'll need these for later to show the User
        //That they've obtained them.
        itemNeeded1 = GameObject.Find("Item1_Needed");
        comboItemNeeded1 = GameObject.Find("Item2_Needed");
    }
    void Update()
    {
        if ((!Input.GetMouseButton(0)) && collided)
        {
            Combo_Manager.slot2Filled = true;
            collided = false;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        collided = true;

        tagToCompare = other.tag;
        Debug.Log("Tag we got is: " + tagToCompare);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Combo_Manager.slot2Filled = false;
        tagToCompare = "";
        collided = false;
        Debug.Log("We left the collision!");
    }
}