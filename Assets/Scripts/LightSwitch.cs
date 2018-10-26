using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{

	public GameObject light;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		light.SetActive(false);
	}

	void OnTriggerExit(Collider other)
	{
		light.SetActive(true);
	}
}
