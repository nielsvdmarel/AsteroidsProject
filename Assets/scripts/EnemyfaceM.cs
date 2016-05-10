using UnityEngine;
using System.Collections;

public class EnemyfaceM : MonoBehaviour {

   public float rotSpeed = 90f;

    Transform MoederBoord;
	
	void Update ()
    {
	    if(MoederBoord == null)
        {
            //find player ship
           GameObject go = GameObject.Find("MoederBoord");

            if(go != null)
            {
                MoederBoord = go.transform;
            }
        }

        if (MoederBoord == null)
            return;

        Vector3 dir = MoederBoord.position - transform.position;
        dir.Normalize();

        float zAngel = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngel);

        transform.rotation = Quaternion.RotateTowards ( transform.rotation, desiredRot , rotSpeed * Time.deltaTime);

        //testline

	}
}
