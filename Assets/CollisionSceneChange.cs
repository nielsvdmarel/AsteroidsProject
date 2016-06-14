using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CollisionSceneChange : MonoBehaviour
{


    void onCollisionEnter2D(Collision2D coll)
    {
        
            

        
        Application.LoadLevel(Application.loadedLevel + 1);

        
    }

    


}