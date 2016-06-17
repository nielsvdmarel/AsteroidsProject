using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public string scene;

    public void NielsTestScene()
    {
       
        Initiate.Fade(scene, Color.black, 0.5f);
    }

    
}
