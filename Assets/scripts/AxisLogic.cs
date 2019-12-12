using UnityEditor;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class AxisLogic : MonoBehaviour
{
	public string axi;

	public void scalate(){
		GameObject parent = transform.parent.gameObject;
		if(parent != null) {
			parent = parent.transform.parent.gameObject;
			if(parent != null){
				Vector3 add = new Vector3(0.0f,0.0f,0.0f);
				if(axi == "x") add.x = 0.1f;
				if(axi == "y") add.y = 0.1f;
				if(axi == "z") add.z = 0.1f;
				if (VRLogic.mode == VRLogic.SCALATION_NEG ||
					VRLogic.mode == VRLogic.MOVEMENT_NEG ||
					VRLogic.mode == VRLogic.ROTATION_NEG)
						add = add*-1.0f;
				if(VRLogic.mode == VRLogic.SCALATION || VRLogic.mode == VRLogic.SCALATION_NEG)
					parent.transform.localScale += add;
				if(VRLogic.mode == VRLogic.MOVEMENT || VRLogic.mode == VRLogic.MOVEMENT_NEG)
					parent.transform.localPosition += (add*5);
				if(VRLogic.mode == VRLogic.ROTATION || VRLogic.mode == VRLogic.ROTATION_NEG) { 
					Vector3 rot = parent.transform.localRotation.eulerAngles;
					rot = rot + (add*50);
					parent.transform.localRotation = Quaternion.Euler(rot);
				}
			}
		}
	}

}
