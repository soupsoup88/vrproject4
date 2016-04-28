using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;





public class playaudio : MonoBehaviour, IPointerClickHandler {





	public AudioSource audio;
	public AudioSource audio1;
	public AudioSource audio2;
	public Animator animator;


	public void OnPointerClick(PointerEventData eventData)
	{

		audio.Play ();
		audio1.Stop ();
		audio2.Stop ();
		animator.SetBool ("yes",true);
		animator.SetBool ("no",false);
		StartCoroutine(Example());



	}




IEnumerator Example() {

	yield return new WaitForSeconds(8);
		PlayerPrefs.SetInt("city",1);
		Application.LoadLevel (0);
}
}