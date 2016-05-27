#pragma strict
var target : GameObject;
function Start () {
 
}
 
function Update () {
    transform.position.x = target.transform.position.x;
    
    transform.position.y = target.transform.position.y;
}