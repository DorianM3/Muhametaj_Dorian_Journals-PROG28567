using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    Vector2 store = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Create a vector2 that checks the mouse position 
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Stores the mouse scrolls so they can be added to the points 
        store.x += Input.mouseScrollDelta.y * 0.05f;
        store.y += Input.mouseScrollDelta.y * 0.05f;
        //Creates a point that is to the bottom left of the mouse 
        Vector2 point1 = mouse - Vector2.one;
        point1.x -= store.x; 
        point1.y -= store.y; 
        //Creates a point that is to the top left of the mouse 
        Vector2 point2 = mouse;
        point2.x -= 1;
        point2.y += 1;
        point2.x -= store.x; 
        point2.y += store.y;
        //Creates a point that is to the top right of the mouse 
        Vector2 point3 = mouse + Vector2.one;
        point3.x += store.x; 
        point3.y += store.y; 
        //Creates a point to the bottom right of the mouse
        Vector2 point4 = mouse;
        point4.y -= 1;
        point4.x += 1;
        point4.x += store.x; 
        point4.y -= store.y; 
        //If a left click input is completed the square will be drawn, connecting the 4 points 
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(point2); 
            Debug.DrawLine(point1, point2, Color.red, 100f);
            Debug.DrawLine(point2, point3, Color.red, 100f);
            Debug.DrawLine(point3, point4, Color.red, 100f);
            Debug.DrawLine(point4, point1, Color.red, 100f);
        }
    }
}
