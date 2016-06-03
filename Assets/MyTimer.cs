using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MyTimer : MonoBehaviour
{



    private Text timertext;
    public int myTimer2;
    public int defaulttimer;

    void Start()
    {
        
        
    }


    

    public void StartTimer()
    {
        timertext = GetComponent<Text>();


        StartCoroutine(timerfunction());
    }


    void Update()
    {

        if (timertext != null)
        {
                

                        if (myTimer2 > 0)
                        {

                timertext.text = "" + myTimer2;





            }
        }

        


    }

    IEnumerator timerfunction()
    {
        while (myTimer2 > 0)
        {
            yield return new WaitForSeconds(1);
            myTimer2 -= 1;
        }

        if (myTimer2 == 0)
        {

            //timertext.enabled = false;
            timertext.text = "";
            speedreset(GameObject.Find("Player").GetComponent<PlayerMovementAst>().defaultspeed);
            
            
        }




    }

    public void speedreset(float speedchange)
    {
        GameObject.Find("Player").GetComponent<PlayerMovementAst>().ThrustForce = speedchange;
    }

    public void resetTimer()
    {

        myTimer2 = defaulttimer;
        
    }

    
}
