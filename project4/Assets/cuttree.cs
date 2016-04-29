using UnityEngine;
using System.Collections;

public class cuttree : MonoBehaviour {

	public AudioSource audio;
	public AudioSource audio1;
	// Use this for initialization
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("camera"))
		{
			audio.Play ();
			audio1.Stop ();

		}
	}

	

}
