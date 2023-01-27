using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] BeatColor color;

    SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnEnable()
    {
        //임시 색바꾸기 코드
        switch ((int)color)
        {
            case 1:
                spriteRenderer.color = Color.red;
                break;
            case 2:
                spriteRenderer.color = Color.blue;
                break;
            case 3:
                spriteRenderer.color = Color.yellow;
                break;
            case 4:
                spriteRenderer.color = Color.green;
                break;
            case 5:
                spriteRenderer.color = Color.grey;
                break;
            case 6:
                spriteRenderer.color = Color.white;
                break;


        }
    }
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
}
