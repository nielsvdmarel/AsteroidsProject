using UnityEngine;
using System.Collections;

public class extaMovement : MonoBehaviour {

    public float startmoving;
    public float moveAgain;
    public bool move;

    // Use this for initialization
    void Start () {
        this.GetComponent<EnemyMovement>().stopMoving = false;
        this.GetComponent<EnemyMovement>().setTarget(GameObject.Find("player").transform);
        this.GetComponent<EnemyfaceM>().target = GameObject.Find("player");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
