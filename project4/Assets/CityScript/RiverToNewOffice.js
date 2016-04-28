#pragma strict

function Start () {

}

function Update () {
	
}

function switchToNewOffice()
{	
	yield WaitForSeconds(20);

	PlayerPrefs.SetInt("office",1);
	Application.LoadLevel (1);
}