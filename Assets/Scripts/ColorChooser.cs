using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChooser : MonoBehaviour
{
    public Color Red;
    public Color Green;
    public Color Yellow;
    public Color Orange;
    public GameObject Crosshair;
    
    public Sprite redcolorsprite;
    public Sprite greencolorsprite;
    public Sprite yellowcolorsprite;
    public Sprite orangecolorsprite;


    private void Awake()
    {
        Crosshair.GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void redColor()
    {
        CubeSelector.instance.colormaster = Red;
        Crosshair.GetComponent<SpriteRenderer>().sprite = redcolorsprite;

    }

    public void greencolor()
    {
        CubeSelector.instance.colormaster = Green;
        Crosshair.GetComponent<SpriteRenderer>().sprite = greencolorsprite;
    }

    public void yellowColor()
    {
        CubeSelector.instance.colormaster = Yellow;
        Crosshair.GetComponent<SpriteRenderer>().sprite = yellowcolorsprite;
    }

    public void orangeColor()
    {
        CubeSelector.instance.colormaster = Orange;
        Crosshair.GetComponent<SpriteRenderer>().sprite = orangecolorsprite;
    }




}
