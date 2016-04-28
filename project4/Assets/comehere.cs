using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class comehere : MonoBehaviour, IPointerClickHandler { 
	public GameObject sphere;
	private Vector3 offset;
	private bool a;
	//public AudioSource audio; 
	// Use this for initialization
	void Start () {
		a=false;
		offset = transform.position - sphere.transform.position;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		print ("click");
		a = !a;
		transform.position = new Vector3 (sphere.transform.position.x - 1.3f, sphere.transform.position.y - 1.3f, sphere.transform.position.z + 4.5f);
		transform.localRotation = Quaternion.Euler (new Vector3 (0.0f, -140.0f, 0.0f));
	}





	void LateUpdate ()
	{  if(a)
		transform.position = sphere.transform.position + new Vector3(-1.3f,-1.3f,4.5f);
	}




	// Update is called once per frame
	void Update () {
	
	}
}
