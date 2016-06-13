using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public void NielsTestScene()
    {
        SceneManager.LoadScene("NielsTestScene");
    }

    

    public void MainMenu()
    {
        SceneManager.LoadScene("main menu");
    }

    public void movetut()
    {
        SceneManager.LoadScene("movetut");
    }

}
