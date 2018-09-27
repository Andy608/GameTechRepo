using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class MakeRed : MonoBehaviour 
{
	private MeshRenderer objRenderer;

	private void Start()
	{
		objRenderer = GetComponent<MeshRenderer>();
	}

	private void OnEnable()
	{
		Managers.EventManager.OnSampleAction += ChangeColor;
	}

	private void OnDisable()
	{
		Managers.EventManager.OnSampleAction -= ChangeColor;
	}

	private void ChangeColor()
	{	
		objRenderer.material.color = Color.red;
	}
}
