#pragma strict
import UnityStandardAssets.Characters.FirstPerson;
var oldTown : GameObject;
var developingTown : GameObject;
var developedTown : GameObject;
var newTown : GameObject;
var car : GameObject;
var person : GameObject;
var crowd : GameObject;

function Start () {
	switch(PlayerPrefs.GetInt("city"))
	{
		case 1:
			oldTown.SetActive(false);
			developingTown.SetActive(true);
			developedTown.SetActive(false);
			newTown.SetActive(false);
			var teleportPosition : Vector3;
			var cameraPosition : Vector3;
			cameraPosition = Vector3(0, 0.8, 0);
			person.transform.localPosition.x = cameraPosition.x;
			person.transform.localPosition.y = cameraPosition.y;
			person.transform.localPosition.z = cameraPosition.z;
			teleportPosition = Vector3(987.004, 101.163, 492.623);
			transform.position.x = teleportPosition.x;
			transform.position.y = teleportPosition.y;
			transform.position.z = teleportPosition.z;
			transform.parent = car.transform;
			gameObject.GetComponent.<RigidbodyFirstPersonController>().enabled = false;
			break;
		case 2:
			oldTown.SetActive(false);
			developingTown.SetActive(false);
			developedTown.SetActive(true);
			newTown.SetActive(false);
			break;
		case 3:
			oldTown.SetActive(false);
			developingTown.SetActive(false);
			developedTown.SetActive(true);
			newTown.SetActive(false);
			crowd.SetActive(true);
			var teleportPosition1 : Vector3;
			var cameraPosition1 : Vector3;
			cameraPosition1 = Vector3(0, 1.2, 0);
			person.transform.localPosition.x = cameraPosition1.x;
			person.transform.localPosition.y = cameraPosition1.y;
			person.transform.localPosition.z = cameraPosition1.z;
			teleportPosition1 = Vector3(361.55, 101.163, 610.77);
			transform.position.x = teleportPosition1.x;
			transform.position.y = teleportPosition1.y;
			transform.position.z = teleportPosition1.z;
			break;
		case 4:
			oldTown.SetActive(false);
			developingTown.SetActive(false);
			developedTown.SetActive(false);
			newTown.SetActive(true);
			var teleportPosition2 : Vector3;
			var cameraPosition2 : Vector3;
			cameraPosition2 = Vector3(0, 1.2, 0);
			person.transform.localPosition.x = cameraPosition2.x;
			person.transform.localPosition.y = cameraPosition2.y;
			person.transform.localPosition.z = cameraPosition2.z;
			teleportPosition2 = Vector3(361.55, 101.163, 610.77);
			transform.position.x = teleportPosition2.x;
			transform.position.y = teleportPosition2.y;
			transform.position.z = teleportPosition2.z;
			break;
		default:
			oldTown.SetActive(true);
			developingTown.SetActive(false);
			developedTown.SetActive(false);
			newTown.SetActive(false);
			break;
	}

}

function Update () {

}

function OnDestroy()
{
	PlayerPrefs.SetInt("city",0);
}