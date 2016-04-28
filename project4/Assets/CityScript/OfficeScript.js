#pragma strict
import UnityStandardAssets.Characters.FirstPerson;
var oldOffice : GameObject;
var newOffice : GameObject;
var person : GameObject;

function Start () {
	switch(PlayerPrefs.GetInt("office"))
	{
		case 1:
			oldOffice.SetActive(false);
			newOffice.SetActive(true);
			var teleportPosition : Vector3;
			teleportPosition = Vector3(-5.692, 3.214, 17.383);
			transform.position.x = teleportPosition.x;
			transform.position.y = teleportPosition.y;
			transform.position.z = teleportPosition.z;
			gameObject.GetComponent.<RigidbodyFirstPersonController>().enabled = false;
			break;
		default:
			oldOffice.SetActive(true);
			newOffice.SetActive(false);
			break;
	}

}

function Update () {

}

function OnDestroy()
{
	PlayerPrefs.SetInt("office",0);
}