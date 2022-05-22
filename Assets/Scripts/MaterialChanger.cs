using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
   
    public static MaterialChanger instance;
    // Start is called before the first frame update

    public SpriteRenderer spriteRenderer;
    //public Color color1;

    private void Awake()
    {
        instance = this;
       spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        Cursor.visible = true;
    }
    void Start()
    {
        //spriteRenderer.color = color1;
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
