using UnityEngine;
using System.Collections;

public class Blip : MonoBehaviour
{

    public Transform Target;

    MiniMap map;
    RectTransform myRectTransform;

    void start()
    {
        map = GetComponentInParent<MiniMap>();
        myRectTransform = GetComponent<RectTransform>();
    }

    void LateUpdate()
    {
       Vector2 newPosition = map.TransformPosition(Target.position);

        myRectTransform.localPosition = newPosition;
    }
}

