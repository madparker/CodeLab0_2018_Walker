using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportOnTrigger : MonoBehaviour
{
	public Vector3 position = new Vector3(0, 10, 0);
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		other.gameObject.transform.position = position;
		print("TElEPORT!");
	}
}
