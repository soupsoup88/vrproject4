using UnityEngine;
using System.Collections;

public class doctorshuo : MonoBehaviour {

		public Transform target1;
		public float speed1;
		private Vector3 dir;
		private Vector3 mydocter;
		private Vector3 mycamera;
		public Animation docteranimation;
		public Animator docteranimator;
		public float interval1 = 0.001f;
		public float currentTime1 = 0f;
		public float step1;
		public AudioSource docter1;
		public AudioSource docter2;

		float dist;
		int a = 0;
		int b = 0;

	// Update is called once per frame
	void Update() {

		docteranimation = GetComponent<Animation>();
		mycamera = target1.position;
		mydocter = transform.position;
		mycamera.y = mydocter.y;
		transform.LookAt(mycamera);

		if (Time.time > currentTime1) {
			currentTime1 = Time.time + interval1;
			step1 = speed1 * interval1;
		}

		dist =Vector3.Distance(transform.position,target1.position);
		print (dist);
		if ((dist > 5f))
		{
			docteranimator.SetBool ("find", true);
			docteranimation.Play ("walk");
			docteranimation.Stop ("idle");
			mydocter = transform.position;
			mycamera = target1.position;
			mydocter.y = 0;
			mycamera.y = 0;
			transform.position = Vector3.MoveTowards(mydocter, mycamera, step1);
			print (dist);
		} 

		if(!(dist>4f))
		{
			print (dist);
			docteranimator.SetBool ("talk", true);
			if ((!docter1.isPlaying) && (a == 0)) {
				docter1.Play ();
				a = 1;
			}

			if ((!docter1.isPlaying) && (a == 1)&&(b == 0)) {
				docter2.Play ();
				b = 1;
			}

			if ((!docter2.isPlaying)&&(a == 1)&&(b ==1)) {
			docteranimator.SetBool ("stop", true);
			}
			print ("I find you");
			//trigger animation;
		}
	}
}

