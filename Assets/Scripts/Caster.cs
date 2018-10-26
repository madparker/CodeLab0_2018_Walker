using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caster : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//print(transform.forward);
		
		RaycastHit hitInfo = new RaycastHit();

		//if (Physics.Raycast(transform.position, transform.forward, out hitInfo, 10f))
		if(Physics.SphereCast(transform.position, 0.1f, transform.forward, out hitInfo, 10f))
		{
			print("HIT:" + hitInfo.collider.gameObject);
		}
		
		Debug.DrawRay(transform.position, transform.forward, Color.green);

	}
}
