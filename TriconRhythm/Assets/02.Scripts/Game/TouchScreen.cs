using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScreen : MonoBehaviour
{
    int rot = 60;
    int index = 0;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            index--;
            rot -= 120;
            Turn();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            index++;
            rot += 120;
            Turn();
        }
    }

    public void Turn()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, rot);
        switch (Mathf.Abs(index) % 3)
        {
            case 0:
                transform.position = new Vector2(-0.6f, -5.6f);
                break;
            case 1:
                transform.position = new Vector2(-0.6f, -5.58f);
                break;
            case 2:
                transform.position = new Vector2(0f, -6.58f);
                break;
        }

    }
}
