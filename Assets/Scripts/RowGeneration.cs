using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowGeneration : MonoBehaviour
{
    public int SquareNumberInput;
    Vector2 start = Vector2.one;
    Vector2 end = Vector2.one;
    Vector2 startParallel;
    Vector2 endParallel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Go()
    {
        if (SquareNumberInput > 0)
        {
            start.x *= -11;
            end.x *= (-11 + SquareNumberInput);

            startParallel = start;
            startParallel.y -= 1;

            endParallel = end;
            endParallel.y -= 1;

            Debug.DrawLine(start, end, Color.red, 100f);
            Debug.DrawLine(startParallel, endParallel, Color.red, 100f);

            for (int i = 0; i < SquareNumberInput + 1; i++)
            {
                start.x += i;
                startParallel.x += i;
                Debug.DrawLine(start, startParallel, Color.red, 100f);
                start.x -= i;
                startParallel.x -= i;
            }
        } 
    }
}
