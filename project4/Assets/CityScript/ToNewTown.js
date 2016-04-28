#pragma strict

function Start () {

}

function Update () {

}

function switchToNewTown()
{
	PlayerPrefs.SetInt("city",4);
	Application.LoadLevel (0);
}