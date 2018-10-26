using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnTrigger : MonoBehaviour
{
	public AudioSource audio;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
    void OnTriggerEnter(Collider other)
    {
	    audio.Play();
    }
    
	void OnTriggerExit(Collider other)
	{
		audio.Stop();
	}
}
