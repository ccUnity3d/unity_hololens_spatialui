using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SPButton : MonoBehaviour, IInputClickHandler, IFocusable
{
	public TextMesh _buttonText;
	public Collider _buttonCollider;
	

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void OnInputClicked(InputClickedEventData eventData)
	{
		//throw new NotImplementedException();
	}

	public void OnFocusEnter()
	{
		//throw new NotImplementedException();
	}

	public void OnFocusExit()
	{
		//throw new NotImplementedException();
	}
}
