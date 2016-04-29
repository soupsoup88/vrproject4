#pragma strict
var Secretary : GameObject;

function Start () {

}

function Update () {
	var audio : AudioSource = gameObject.GetComponent.<AudioSource>();
	if(!audio.isPlaying)
	{
		Secretary.SetActive(true);
	}
}