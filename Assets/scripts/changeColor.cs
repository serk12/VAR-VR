using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public void Red()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    public void Blue()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }
    public void Black()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.black;
    }

}
