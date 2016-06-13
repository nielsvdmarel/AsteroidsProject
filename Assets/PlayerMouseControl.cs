using UnityEngine;
using System.Collections;

public class PlayerMouseControl : MonoBehaviour {

    public float rotSpeed = 0.01f;
    private Vector2 oldMousePos;

    private bool stopmove;

    // Use this for initialization
    void Start () {
        

        
    }
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("enemies").GetComponent<waveScript>().playercanmove)
        {
            Vector2 mousePos = Input.mousePosition;
       
            Vector2 dir = Camera.main.ScreenToWorldPoint(mousePos) - transform.position;
            dir.Normalize();

            float zAngel = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

            Quaternion desiredRot = Quaternion.Euler(0, 0, zAngel);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);

            oldMousePos = mousePos;
            
        }
    }
}
