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
				Vector3 scalate = new Vector3(0.0f,0.0f,0.0f);
				if(axi == "x") scalate.x = 0.1f;
				if(axi == "y") scalate.y = 0.1f;
				if(axi == "z") scalate.z = 0.1f;
				parent.transform.localScale += scalate;
			}
		}
	}

}
