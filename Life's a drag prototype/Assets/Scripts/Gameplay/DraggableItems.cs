using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableItems : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    // Start is called before the first frame update
    /** void Start()
    {
        
    }
    */

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.touchCount > 0)
        {
           Touch touch = Input.GetTouch(0);
           Vector3 touchPosition =  Camera.main.ScreenToWorldPoint(touch.position);
           touchPosition.z = 0f;
           transform.position = touchPosition;
        }
        */
    }
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
       // Destroy(this.GetComponent<PolygonCollider2D>());
       // this.gameObject.AddComponent<PolygonCollider2D>();
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    void OnMouseUp()
    {
        //this.gameObject.AddComponent<PolygonCollider2D>();
        //Debug.Log("dropped!");
    }
}
