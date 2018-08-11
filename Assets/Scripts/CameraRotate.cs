using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class CameraRotate : MonoBehaviour
{
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton(0))
		{
			transform.Rotate(Vector3.up, 500*Time.deltaTime*Input.GetAxis("Mouse X"));
		}
	}
}
