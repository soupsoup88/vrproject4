
	using UnityEngine;
	using System.Collections;
	using UnityEngine.EventSystems;


	public class clickcomputer : MonoBehaviour, IPointerClickHandler {




		public GameObject obenable;
	    public GameObject obdisable;

		public void OnPointerClick(PointerEventData eventData)
		{

		obenable.SetActive (true);
		obdisable.SetActive (false);





		}
	}
