using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform TranslatePosition;

    private void OnTriggerEnter(Collider _col)
    {
        if(other.gameObject.tag == "Player")
        {
            Transform ParentTransform = _col.transform;
            
            while (true)
            {
                if (ParentTransform.parent == null)
                    break;
                else
                    ParentTransform = ParentTransform.parent;

            }

            ParentTransform.position = TranslatePosition.position;
            ParentTransform.rotation = TranslatePosition.rotation;
        }
    }
}