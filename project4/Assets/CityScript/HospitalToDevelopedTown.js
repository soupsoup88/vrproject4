#pragma strict

function Start () {

}

function Update () {

}

function OnCollisionEnter(col : Collision) {
	switchToDevelopedTown();
}

function switchToDevelopedTown()
{
	PlayerPrefs.SetInt("city",3);
	Application.LoadLevel (0);
}