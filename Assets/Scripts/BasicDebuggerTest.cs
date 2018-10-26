using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDebuggerTest : MonoBehaviour
{

	public GameObject temp;	//declare
	public TextMesh textMesh; //declared and I will init in Inspector

	int numberOfFramesGoneBy;
	
	// Use this for initialization
	void Start () {
		//temp = GameObject.Find("Floor"); //init in code
		textMesh = GameObject.Find("New Text").GetComponent<TextMesh>();
		numberOfFramesGoneBy = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("temp: " + temp);

		//Debug.Log("temp.transform.position.z: " + temp.transform.position.z);
		if (temp.transform.position.z < 0)
		{
			Debug.Log("True: temp.transform.position.z < 0");
			temp.transform.position = new Vector3(0, 1, 10); //use
		}
		else
		{
			Debug.Log("False: temp.transform.position.z < 0");
		}

		Debug.Log("numberOfFramesGoneBy = " + numberOfFramesGoneBy);
		textMesh.text = "Frames: " + numberOfFramesGoneBy;

		if (numberOfFramesGoneBy > 500)
		{
			textMesh.color = Color.red;
		}

		numberOfFramesGoneBy = numberOfFramesGoneBy + 1;
	}
}
