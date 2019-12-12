using UnityEditor;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Menu : MonoBehaviour
{

    public void Start()
    {
        VRLogic.mode = VRLogic.NAVIGATION_OUT;
    }

    public void clickOnModeButton()
    {
        if (name == "POISelectionButton")
        {

            if (VRLogic.mode == VRLogic.NAVIGATION_IN)
            {
                Debug.Log("NAVIGATION_IN to POI_LOCATION");
                VRLogic.mode = VRLogic.POI_LOCATION;
            }
        }
        else if (name == "ExitButton")
        {
            if (VRLogic.mode == VRLogic.NAVIGATION_OUT)
            {
                //EXIT
            }
            else
            {
                VRLogic.mode = VRLogic.NAVIGATION_OUT;
                //TODO: Move Camera and everything out
            }
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
        updateColorsOnButtons();
        updateText();
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
        /* FIX THIS IS NOT ANDROID COMPATIBLE
        if (VRLogic.mode == VRLogic.POI_LOCATION)
        {
            Texture2D grey = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/models/blenders/Menu/grey_marker.png", typeof(Texture2D));
            GameObject.Find("POISelectionButton").GetComponent<Renderer>().material.mainTexture = grey;

        }
        else {
            Texture2D green = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/models/blenders/Menu/green_marker.png", typeof(Texture2D));
            GameObject.Find("POISelectionButton").GetComponent<Renderer>().material.mainTexture = green;
        }
        */

    }
    public void Update()
    {
        /*Camera cam = Camera.main;
        float distanceFromCamera = 2.0f;
        //Vector3 direction = Quaternion.AngleAxis(-45, Vector3.up) * cam.transform.forward;
        Vector3 direction = cam.transform.forward;
        Vector3 resultingPosition = cam.transform.position + direction * distanceFromCamera;
        transform.position = resultingPosition;
        //transform.LookAt(cam.transform);
        // transform.Rotate(0, 0, 40); */

    }

}
