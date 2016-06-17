using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class Collisionentertopickup : MonoBehaviour{

    public string scene;

    void OnCollisionEnter2D(Collision2D coll)
    {

       

        Initiate.Fade(scene, Color.black, 0.5f);


    }


}
