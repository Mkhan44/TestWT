using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo_Collision : MonoBehaviour
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
            /*
            if (counter == 0)
            {
                if (tagToCompare == "Item1")
                {
                    Color tmp = itemNeeded1.GetComponent<SpriteRenderer>().color;
                    tmp.a = 1f;
                    itemNeeded1.GetComponent<SpriteRenderer>().color = tmp;

                    Debug.Log("Potion is in the right spot!");
                    counter++;
                }
                else
                {
                    Debug.Log("No, the heart doesn't belong here!");
                }
            }
            else
            {
                if (tagToCompare == "ComboItem1")
                {
                    Debug.Log("You got the combo!");
                    counter++;
                }
                else
                {
                    Debug.Log("No, the heart doesn't belong here!");
                }
            }
            */
            Combo_Manager.slot1Filled = true;
            collided = false;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        collided = true;
       
        tagToCompare = other.tag;
        Debug.Log("Tag we got is: " + tagToCompare);
        /*
        if (other.gameObject.CompareTag("Item1") && Input.GetMouseButtonDown(0))
        {
            other.gameObject.SetActive(false);
            Debug.Log("Potion is in the right spot!");
        }
        else
        {
            Debug.Log("No, the heart doesn't belong here!");
        }
         */
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Combo_Manager.slot1Filled = false;
        tagToCompare = "";
        collided = false;
        Debug.Log("We left the collision!");
    }
}
