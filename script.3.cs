using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    public Transform user;
    public Transform reciever;

    private bool playerisoverlapping = false;

    private void Update()
    {
        if(playerisoverlapping)
        {
            Vector3 toPlayer = user.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, toPlayer);

            if (dotProduct < 0f)
            {
                float rotaionDiff = -Quaternion.Angle(transform.rotation, reciever.rotation);
                rotaionDiff += 180;
                user.Rotate(Vector3.up, rotaionDiff);

                Vector3 postionOffset = Quaternion.Euler(0f, rotaionDiff, 0f) * toPlayer;
                user.position = reciever.position + postionOffset;

                playerisoverlapping = false;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
         if (other.tag == "user")
        {
            playerisoverlapping = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "user")
        {
            playerisoverlapping = false;
        }
    }

}