using UnityEngine;
using System.Collections;

public class extaMovement : MonoBehaviour {

    public float startmoving;
    public float moveAgain;
    public float speed;

    private float X;
    private float Y;
    private Transform targetGet;
    private Vector2 targetSet;


    private GameObject player;
    
    void Start () {
        player = GameObject.Find("Player");
        targetGet = player.transform;
        InvokeRepeating("setNewTarget", startmoving, moveAgain);
        targetSet = new Vector2(this.transform.position.x, this.transform.position.y);
    }
	
	void Update () {
        this.GetComponent<EnemyfaceM>().target = player;
        if (!player.GetComponent<Collider2D>().isTrigger)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetSet, speed * Time.deltaTime);
        }
    }

    private void setNewTarget()
    {
        if (!player.GetComponent<Collider2D>().isTrigger)
        {
            X = targetGet.position.x;
            Y = targetGet.position.y;
            targetSet = new Vector2(X, Y);
        }
    }
    private void test()
    {
        Debug.Log("test uitgevoerd");
    }
}
