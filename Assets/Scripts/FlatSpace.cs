using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatSpace : MonoBehaviour {

	public event Action<FlatSpace> OnFlatClicked;
	public Flat Occupant; 
    
	private void OnMouseUp()
	{
		if (OnFlatClicked != null) OnFlatClicked(this);
	}
}
