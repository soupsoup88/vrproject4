#pragma strict

function Start () {

}

function Update () {

}

function switchToDevelopingTown()
{
	PlayerPrefs.SetInt("city",1);
	Application.LoadLevel (0);
}