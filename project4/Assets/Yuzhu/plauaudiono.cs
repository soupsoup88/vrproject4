using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;





public class plauaudiono : MonoBehaviour {







	public Animator animator;


	public AudioSource audio;

	// Use this for initialization
	void OnTriggerEnter(Collider other) 
	{
		audio.Play ();
		animator.SetBool ("nanny", true);

	}


}
