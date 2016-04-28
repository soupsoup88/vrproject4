#pragma strict
var person : GameObject;
var pcamera : GameObject;

function Start () {

}

function Update () {

}

function driveThroughOldTown()
{
	gameObject.GetComponent.<BoxCollider>().enabled = false;
	var teleportPosition : Vector3;
	var cameraPosition : Vector3;
	cameraPosition = Vector3(0, 0.8, 0);
	pcamera.transform.localPosition.x = cameraPosition.x;
	pcamera.transform.localPosition.y = cameraPosition.y;
	pcamera.transform.localPosition.z = cameraPosition.z;
	teleportPosition = Vector3(179.59, 101.163, 492.41);
	person.transform.position.x = teleportPosition.x;
	person.transform.position.y = teleportPosition.y;
	person.transform.position.z = teleportPosition.z;
	person.GetComponent.<RigidbodyFirstPersonController>().enabled = false;
	gameObject.GetComponent.<Animator>().SetBool("click", true);
	person.transform.parent = transform;
}

function switchToOldOffice()
{
	Application.LoadLevel (1);
}