#pragma strict
var person : GameObject;
var pcamera : GameObject;

function Start () {

}

function Update () {

}

function OnTriggerEnter(col : Collider) {
	if(col.gameObject.tag == "mayorCarCollider")
	{   print("detected");
		person.GetComponent.<RigidbodyFirstPersonController>().enabled = true;
		person.transform.parent = null;
		var cameraPosition : Vector3;
		cameraPosition = Vector3(0, 2.15, 0);
		pcamera.transform.localPosition.x = cameraPosition.x;
		pcamera.transform.localPosition.y = cameraPosition.y;
		pcamera.transform.localPosition.z = cameraPosition.z;
	}
}