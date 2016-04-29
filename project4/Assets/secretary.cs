using UnityEngine;
using System.Collections;

public class secretary : MonoBehaviour {

	public Transform target1;
	public float speed1;
	private Vector3 dir;
	private Vector3 mysecretary;
	private Vector3 mycamera;
	public Animation secretaryanimation;
	public Animator secretaryanimator;
	public float interval1 = 0.001f;
	public float currentTime1 = 0f;
	public float step1;
	public AudioSource secretary1;
	public AudioSource journalist;
	public GameObject choice;


	float dist;
	int a = 0;


	// Update is called once per frame
	void Update() {

		secretaryanimation = GetComponent<Animation>();
		mycamera = target1.position;
		mysecretary = transform.position;
		mycamera.y = mysecretary.y;
		transform.LookAt(mycamera);

		if (Time.time > currentTime1) {
			currentTime1 = Time.time + interval1;
			step1 = speed1 * interval1;
		}

		dist =Vector3.Distance(transform.position,target1.position);
		if ((dist > 5f))
		{
			
			secretaryanimation.Play ("walk");
			secretaryanimation.Stop ("idle");
			mysecretary = transform.position;
			mycamera = target1.position;
			mysecretary.y = 0;
			mycamera.y = 0;
			transform.position = Vector3.MoveTowards(mysecretary, mycamera, step1);
		} 

		if(!(dist>4f))
		{
			secretaryanimator.SetBool ("talk", true);

			if ((!secretary1.isPlaying) && (a == 0)&&(!journalist.isPlaying)) {
				Debug.Log ("I should give voice");

				secretary1.Play ();
				choice.SetActive (true);
				secretaryanimator.SetBool ("stop", true);
				a = 1;
			}

			print ("I find you");
			//trigger animation;
		}
	}
}

