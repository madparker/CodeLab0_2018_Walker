using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHallway : MonoBehaviour
{

	public MeshRenderer mesh;
	Material mat;
	
	// Use this for initialization
	void Start ()
	{
		mat = mesh.material;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other)
	{
		print("Trigger Enter");
		mat.color = Color.red;
	}

	void OnTriggerExit(Collider other)
	{
		print("Trigger Exit");
		mat.color = Color.blue;
	}
}
