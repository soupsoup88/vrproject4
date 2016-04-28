using UnityEngine;
using System.Collections;

public class cuttree : MonoBehaviour {

	public AudioSource audio;

	// Use this for initialization
	void OnTriggerEnter(Collider other) 
	{
		audio.Play ();
		
	}

	

}
