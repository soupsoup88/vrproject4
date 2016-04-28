#pragma strict

function Start () {

}

function Update () {

}

function switchToDevelopingTown()
{
	yield WaitForSeconds(5);

	PlayerPrefs.SetInt("city",1);
	Application.LoadLevel (0);
}