

	using UnityEngine;
	using System.Collections;
	using UnityEngine.EventSystems;


	public class computerlast : MonoBehaviour, IPointerClickHandler {




		
		public GameObject obdisable;

		public void OnPointerClick(PointerEventData eventData)
		{
		
			obdisable.SetActive (false);





		}
	}
