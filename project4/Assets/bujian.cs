
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;





public class bujian : MonoBehaviour, IPointerClickHandler {





	public AudioSource audio;
	public AudioSource audio1;
	public AudioSource audio2;
	public Animator animator;


	public void OnPointerClick(PointerEventData eventData)
	{

		audio.Play ();
		audio1.Stop ();
		audio2.Stop ();
		animator.SetBool ("no",true);


	}
}