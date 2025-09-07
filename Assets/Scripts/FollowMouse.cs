using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Makes a vector that tracks mouse position 
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Makes a vector out of the objects scale 
        Vector2 scale = transform.localScale;
        //Allows the scale to gradually change based on the players scroll inputs 
        scale.x += Input.mouseScrollDelta.y * 0.1f;
        scale.y += Input.mouseScrollDelta.y * 0.1f; 
        //Updates position and scale to match the new numbers influenced by the player 
        transform.localScale = scale; 
        transform.position = mouse;
    }
}
