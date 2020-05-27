using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo_Manager : MonoBehaviour
{
    public static bool slot1Filled = false;
    public static bool slot2Filled = false;

    public GameObject itemCombo1; 
    void Update()
    {
        if(slot1Filled && slot2Filled)
        {
            //Do check for combo. 
            Debug.Log("Both slots are filled, we are checking for right combo!");
            if ((Combo_Collision.tagToCompare == "Item2" && Combo_Collision2.tagToCompare == "Item3") || (Combo_Collision.tagToCompare == "Item3" && Combo_Collision2.tagToCompare == "Item2"))
            {
                Instantiate(itemCombo1, transform.position, transform.rotation);
                Debug.Log("We made the treausre chest!");
                Destroy(GameObject.FindWithTag("Item2"));
                Destroy(GameObject.FindWithTag("Item3"));

            }
            
            slot1Filled = false;
            slot2Filled = false;
        }
    }
}
