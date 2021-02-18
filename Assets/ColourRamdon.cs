using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourRamdon : MonoBehaviour
{

    public void RandomColour()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    public void Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
