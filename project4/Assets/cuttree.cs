using UnityEngine;
using System.Collections;

public class cuttree : MonoBehaviour {

	public Animator animator;
	public Animator animator1;
	public Animator animator2;

	// Use this for initialization
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("camera"))
		{
			print("detected");
			animator.SetBool ("chop", true);
			animator1.SetBool ("chop", true);
			animator2.SetBool ("chop", true);

		}
	}

	

}
