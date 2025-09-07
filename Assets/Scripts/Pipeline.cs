using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipeline : MonoBehaviour
{
    public float timer;
    Vector2 store = new Vector2(0, 0); 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1f * Time.deltaTime; 
        if (Input.GetMouseButton(0))
        {
            if (store.x == 0 && store.y == 0)
            {
                store = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }

            if (timer > 0.1f)
            {
                Vector2 playermouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Debug.DrawLine(store, playermouse, Color.red, 100f);
                timer = 0;
                store *= Vector2.zero; 
            }
        }
    }
}
