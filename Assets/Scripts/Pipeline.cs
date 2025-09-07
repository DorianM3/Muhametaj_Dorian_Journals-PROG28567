using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipeline : MonoBehaviour
{
    public float timer;
    Vector2 store = new Vector2(0, 0);
    Vector2 storevalueStart = new Vector2 (0,0);
    Vector2 storevalueEnd;
    Vector2 storevalues; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 0.5f * Time.deltaTime; 
        if (Input.GetMouseButton(0))
        {
            if (store.x == 0 && store.y == 0)
            {
                store = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                if (storevalueStart == Vector2.zero)
                {
                    storevalueStart = store;
                }
            }

            if (timer > 0.1f)
            {
                Vector2 playermouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Debug.DrawLine(store, playermouse, Color.red, 100f);
                timer = 0;
                store *= Vector2.zero; 
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            storevalueEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            storevalues.x += (storevalueEnd.x - storevalueStart.x);
            storevalues.y += (storevalueEnd.y - storevalueStart.y);
            Debug.Log(storevalues.x);
            Debug.Log(storevalues.y); 
            Debug.Log(Mathf.Sqrt(Mathf.Pow(storevalues.x, 2) + Mathf.Pow(storevalues.y, 2))); 
        }
    }
}
