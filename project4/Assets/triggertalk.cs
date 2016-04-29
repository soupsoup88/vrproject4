using UnityEngine;
using System.Collections;

public class triggertalk : MonoBehaviour {

	public GameObject starttalk;

	// Update is called once per frame
		void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "RigidBodyFPSController")
		{ print("I should start to say something");
			starttalk.GetComponent<mysister>().enabled = true;
			
		}
	}
}