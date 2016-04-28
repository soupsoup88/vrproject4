using UnityEngine;
using System.Collections;

public class granny : MonoBehaviour {
	public Animator animator;
	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("camera"))
		{
			print("detected");
			animator.SetBool ("nanny", true);

		}
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
