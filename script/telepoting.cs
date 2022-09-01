using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    public Transform user;
    public Transform reciever;

    private bool PlayerIsOverLapping = false;

    private void Update()
    {
        if(PlayerIsOverLapping)
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

                PlayerIsOverLapping = false;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
         if (other.tag == "user")
        {
            PlayerIsOverLapping = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "user")
        {
            PlayerIsOverLapping = false;
        }
    }

}