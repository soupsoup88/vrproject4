using UnityEngine;
using System.Collections;

public class mysister : MonoBehaviour {


	private Vector3 sister;

	public Animation sisteranimation;
	public Animator sisteranimator;
	public AudioSource cough;
	public AudioSource laytalk; 
	public AudioSource leavedoor;
	public GameObject kongqiqiang;
	float dist;
	int a = 0;
	int b = 0;
	int c = 0;


	// Update is called once per frame
	void Update() {

		sisteranimation = GetComponent<Animation>();
		if (!cough.isPlaying ) {
			sisteranimator.SetBool ("finish", true);
			a = 1;
			if ((!laytalk.isPlaying)&&(b == 0)) {
				laytalk.Play ();
				b = 1;
			}
		}

		if ((!laytalk.isPlaying) && (a == 1)&&( b == 1)) {
			kongqiqiang.SetActive(false);
			if ((!leavedoor.isPlaying) && (c == 0)) {
				leavedoor.Play ();
			}
		}
			
	}
}