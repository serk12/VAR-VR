using UnityEditor;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Menu : MonoBehaviour
{
    public Texture2D grey;
    public Texture2D blue;
    public Texture2D green;

    public int selfMode;
    public int selfModeNeg;

    public void Start()
    {
        VRLogic.mode = VRLogic.NAVIGATION_OUT;
    }

    public void clickOnModeButton()
    {
        if (name == "POISelectionButton")
        {
            VRLogic.mode = VRLogic.POI_LOCATION;
        }
        else if (name == "ExitButton")
        {
            VRLogic.mode = VRLogic.NAVIGATION_OUT;
            Vector3 pos = new Vector3(1.0f, 2.2f, 0.0f);
            (GameObject.FindWithTag("placenta")).GetComponent<PlacentaTeleport>().tpNavigationOut(pos);
        }
        else if (name == "RotateButton")
        {
            if(VRLogic.mode == VRLogic.ROTATION)
                VRLogic.mode = VRLogic.ROTATION_NEG;
            else VRLogic.mode = VRLogic.ROTATION;

        }
        else if (name == "ScaleButton")
        {
            if(VRLogic.mode == VRLogic.SCALATION)
                VRLogic.mode = VRLogic.SCALATION_NEG;
            else VRLogic.mode = VRLogic.SCALATION;

        }
        else if (name == "MoveButton")
        {
            if(VRLogic.mode == VRLogic.MOVEMENT)
                VRLogic.mode = VRLogic.MOVEMENT_NEG;
            else VRLogic.mode = VRLogic.MOVEMENT;

        }
    }

    public void updateText()
    {

        if (VRLogic.mode == VRLogic.NAVIGATION_OUT)
        {
            GameObject.Find("ModeText").GetComponent<Text>().text = "SURGERY ROOM NAVIGATION";

        }
        else if (VRLogic.mode == VRLogic.NAVIGATION_IN)
        {
            GameObject.Find("ModeText").GetComponent<Text>().text = "PLACENTA NAVIGATION";

        }
        else if (VRLogic.mode == VRLogic.POI_LOCATION)
        {
            GameObject.Find("ModeText").GetComponent<Text>().text = "POI SELECTION";

        }
        else if (VRLogic.mode == VRLogic.ROTATION)
        {
            GameObject.Find("ModeText").GetComponent<Text>().text = "ROTATE OBJECTS";

        }
        else if (VRLogic.mode == VRLogic.SCALATION)
        {
            GameObject.Find("ModeText").GetComponent<Text>().text = "SCALE OBJECTS";

        }
        else if (VRLogic.mode == VRLogic.MOVEMENT)
        {
            GameObject.Find("ModeText").GetComponent<Text>().text = "MOVE OBJECTS";
        }
        else if (VRLogic.mode == VRLogic.ROTATION_NEG)
        {
            GameObject.Find("ModeText").GetComponent<Text>().text = "ROTATE OBJECTS NEGATIVE";

        }
        else if (VRLogic.mode == VRLogic.SCALATION_NEG)
        {
            GameObject.Find("ModeText").GetComponent<Text>().text = "SCALE OBJECTS NEGATIVE";

        }
        else if (VRLogic.mode == VRLogic.MOVEMENT_NEG)
        {
            GameObject.Find("ModeText").GetComponent<Text>().text = "MOVE OBJECTS NEGATIVE";
        }


    }

    public void updateColorsOnButtons()
    {
        if (VRLogic.mode == selfMode && !(VRLogic.mode == selfModeNeg)) {
            gameObject.GetComponent<Renderer>().material.mainTexture = grey;
        }
        else if(VRLogic.mode == selfModeNeg) {
            gameObject.GetComponent<Renderer>().material.mainTexture = blue;
        }
        else {
            gameObject.GetComponent<Renderer>().material.mainTexture = green;
        }


    }
    public void Update()
    {
        updateText();
        updateColorsOnButtons();

    }

}
