using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    private Transform target;
    public float speed = 2f;
    public float backSpeed = 1f;
    public float bounceDistance;

    private GameObject motherboard;
    private float minDistance = 1f;
    private float range;
    private float rangeSet;

    public bool forward = false;


    
    void Start ()
    {

        
        motherboard = GameObject.Find("MoederBoord");
        Debug.Log(motherboard.transform.position.x);
        Debug.Log("test");
        target = motherboard.transform;
        forward = true;
        backSpeed = -backSpeed;
    }
	
	
	void Update ()
    {


        
        range = Vector2.Distance(transform.position, target.position);

            //Debug.Log(range);
        if(range > rangeSet + bounceDistance){
            forward = true;
        }
            

            if (forward == true)
            {
               
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, backSpeed * Time.deltaTime);
            }
        

    }

    public void setrange()
    {
        rangeSet = Vector2.Distance(transform.position, target.position);
    }
}

/*using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public Transform target;
    public float speed = 2f;
    private float minDistance = 1f;
    private float range;


    
    void Start ()
    {
	
	}
	
	
	void Update ()
    {

        {
            range = Vector2.Distance(transform.position, target.position);

            if (range > minDistance)
            {
               // Debug.Log(range);

                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
               
               
            }
        }

    }
}
*/
