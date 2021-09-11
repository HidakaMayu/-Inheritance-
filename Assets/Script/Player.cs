using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x >= -5.5f)
            {
                transform.Translate(-3, 0, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x <= 5.5f)
            {
                transform.Translate(3, 0, 0);
            }
        }
    }
}
