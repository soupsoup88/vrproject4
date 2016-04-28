using UnityEngine;
using System.Collections;

public class littlegirl : MonoBehaviour {
	
			public Transform target;
			public float speed;
			private Vector3 dir;
			private Vector3 girl;
			private Vector3 mycamera;
			public Animation girlanimation;
			public Animator girlanimator;
			public float interval = 0.001f;
			public float currentTime = 0f;
			public float step;
			public AudioSource crytalk;
			public AudioSource crying; 
			float dist;
			int a = 0;
			int b = 0;
	
	// Update is called once per frame
void Update() {

			girlanimation = GetComponent<Animation>();
			mycamera = target.position;
			girl = transform.position;
			mycamera.y = girl.y;
			transform.LookAt(mycamera);

			if (Time.time > currentTime) {
				currentTime = Time.time + interval;
				step = speed * interval;
			}

			dist =Vector3.Distance(transform.position,target.position);
		    print (dist);
			if ((dist > 5.5f))
			{
				girlanimator.SetBool ("find", true);
				print("HEY,HEY,HEY,HEY,HEY");
			    girlanimation.Stop("crying");
				crying.Stop();
				girlanimation.Play ("running");
				girl = transform.position;
				mycamera = target.position;
				girl.y = 0;
				mycamera.y = 0;
				transform.position = Vector3.MoveTowards(girl, mycamera, step);
				print (dist);
			} 

			if(!(dist>5f))
			{
			print (dist);
				girlanimator.SetBool ("talk", true);
			if ((!crytalk.isPlaying) && (a == 0)) {
				crytalk.Play ();
				crying.Stop ();
				a = 1;
			}

			if ((!crytalk.isPlaying) && (a == 1)&&(b == 0)) {
				crying.Play ();
				b = 1;
			}
				print ("I find you");
				//trigger animation;
			}
	}
}
