using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

    public float BulletForce;
    public float bulletLifetime;
    
    

    private float life;

    private Rigidbody2D Rigidbody2D;

    void Start()
    {
        life = bulletLifetime;
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Rigidbody2D.AddForce(transform.up * BulletForce);

    }

    void Update()
    {
        life -= Time.deltaTime;
        if (life < 0)
        {
            Destroy(gameObject);
        }
    }
  
    
}
