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
				if(VRLogic.mode == VRLogic.SCALATION)
					parent.transform.localScale += add;
				if(VRLogic.mode == VRLogic.MOVEMENT)
					parent.transform.localPosition += add;
				if(VRLogic.mode == VRLogic.ROTATION){
					Vector3 rot = parent.transform.localRotation.eulerAngles;
					rot = rot + add;
					parent.transform.localRotation = Quaternion.Euler(rot);
				}
			}
		}
	}

}
