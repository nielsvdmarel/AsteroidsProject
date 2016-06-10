using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CollisionSceneChange : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D coll)
    {
        
            SceneManager.LoadScene("Instructions");

        
    }


}