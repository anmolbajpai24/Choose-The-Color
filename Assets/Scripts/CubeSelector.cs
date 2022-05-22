using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSelector : MonoBehaviour
{
    public static CubeSelector instance;

    public GameObject Crosshair;
    public Color colormaster;
    public Sprite Cursor;

    

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {


            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                MaterialChanger.instance.spriteRenderer.color = colormaster ;
                Crosshair.GetComponent<SpriteRenderer>().sprite = Cursor;
            }

        }
    }
}
