using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Collisionentertopickup : MonoBehaviour


	{


    void OnCollisionEnter2D(Collision2D coll)
    {

        SceneManager.LoadScene("pickups");


    }


}
