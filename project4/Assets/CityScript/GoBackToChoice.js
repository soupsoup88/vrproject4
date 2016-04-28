#pragma strict

function Start () {

}

function Update () {

}

function switchToDevelopedTown()
{
	PlayerPrefs.SetInt("city",3);
	Application.LoadLevel (0);
}