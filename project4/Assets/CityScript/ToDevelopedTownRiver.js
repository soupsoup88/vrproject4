#pragma strict

function Start () {

}

function Update () {

}

function switchToDevelopedTown()
{
	PlayerPrefs.SetInt("city",2);
	Application.LoadLevel (0);
}