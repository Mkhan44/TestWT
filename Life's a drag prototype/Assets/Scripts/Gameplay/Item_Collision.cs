using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Collision : MonoBehaviour
{
    string tagToCompare = "";
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

            if (gameObject.name == "Item1_Needed")
            {
                if (tagToCompare == "Item1")
                {
                    Color tmp = itemNeeded1.GetComponent<SpriteRenderer>().color;
                    tmp.a = 1f;
                    itemNeeded1.GetComponent<SpriteRenderer>().color = tmp;

                    Debug.Log("Potion is in the right spot!");
                    Destroy(GameObject.FindWithTag("Item1"));
                    Items_Needed_Manager.item1Done = true;
                }
                
                else
                {
                Debug.Log("No, that doesn't belong in Item1's slot!");
                }
                
            }


            if (gameObject.name == "Item2_Needed")
            {
                if (tagToCompare == "ComboItem1")
                {
                    Color tmp = comboItemNeeded1.GetComponent<SpriteRenderer>().color;
                    tmp.a = 1f;
                    comboItemNeeded1.GetComponent<SpriteRenderer>().color = tmp;
                    Debug.Log("You got the combo!");
                    Destroy(GameObject.FindWithTag("ComboItem1"));
                    Items_Needed_Manager.item2Done = true;
                }
                
                else
                {
                    Debug.Log("What a fail.");
                }
                 
            }
                


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
        tagToCompare = "";
        collided = false;
       // Debug.Log("We left the collision!");
    }
}
