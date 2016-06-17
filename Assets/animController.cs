using UnityEngine;
using System.Collections;

public class animController : MonoBehaviour
{

    private Animator anim;


    void Start()
    {

        anim = GetComponent<Animator>();




    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("testbutton");
            anim.SetBool("die", true);

        }
        else
        {
            anim.SetBool("die", false);
        }
    }
}

