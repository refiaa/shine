using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Animation Anim;
    float MoveSpeed = 2.5f;
    float TurnSpeed = 100f;

    private void Update()
    {
        float V = Input.GetAxis("Vertical");
        float H = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * V * MoveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * H * TurnSpeed * Time.deltaTime);

        if (V == 0f) Anim.CrossFade("Idle", 0.25f);
        else Anim.CrossFade("Walk", 0.25f);
    }
}