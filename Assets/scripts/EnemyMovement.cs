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
        int random = Random.Range(1, 4);
        //random = 3;
        if (random == 1) { transform.position = new Vector3(Random.Range(50F, -50F), 50, 0F); }
        else if (random == 2) { transform.position = new Vector3(Random.Range(50F, 50F),-50, 0F); }
        else if (random == 3) { transform.position = new Vector3(50, Random.Range(50F, -50F), 0F); }
        else if (random == 4) { transform.position = new Vector3(-50, Random.Range(50F, -50F), 0F); }




        motherboard = GameObject.Find("MoederBoord");
        //Debug.Log(Random.Range(-30F, 30F));
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
