using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform TargetPosition;

    private void Start()
    {
        transform.position = TargetPosition.position;
    }

    private void Update()
    {
        transform.position = TargetPosition.position;
    }
}
