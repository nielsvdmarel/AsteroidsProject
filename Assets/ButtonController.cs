using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

    public string scene;


    public void ChangeScene()
    {
        Initiate.Fade(scene, Color.black, 0.5f);
    }

    


}