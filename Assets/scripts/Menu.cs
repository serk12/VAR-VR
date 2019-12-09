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

    public void clickOnPOISelectionModeButton()
    {
        if (VRLogic.mode == VRLogic.NAVIGATION_IN)
        {
            Debug.Log("NAVIGATION_IN to POI_LOCATION");
            VRLogic.mode = VRLogic.POI_LOCATION;
        }
        else if (VRLogic.mode == VRLogic.NAVIGATION_IN)
        {
            Debug.Log("NAVIGATION_IN");

            
        }
        else if (VRLogic.mode == VRLogic.POI_LOCATION)
        {
            Debug.Log("POI_LOCATION");
            Object POISelectionButton = AssetDatabase.LoadAssetAtPath("Assets/models/prefabs/POISelectionModeButton.prefab", typeof(GameObject));
            //GameObject POISelectionButton = (Transform)Resources.Load("Assets/models/prefabs/POISelectionModeButton.prefab", typeof(Transform));
            Instantiate(POISelectionButton, transform.position, Quaternion.identity);

        }
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
        //transform.Rotate(0, 0, 40);*/

    }

}

