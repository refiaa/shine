using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCam : MonoBehaviour
{
    public Transform playerCam;
    public Transform PT;
    public Transform otherPT;

    void Update()
    {
        Vector3 playerOffsetFromPortal = playerCam.position - otherPT.position;
        transform.position = PT.position + playerOffsetFromPortal;

        float angularDifferenceBetweenProtalRotaion = Quaternion.Angle(PT.rotation, otherPT.rotation);

        Quaternion portalRotaionalDifference = Quaternion.AngleAxis(angularDifferenceBetweenProtalRotaion, Vector3.up);
        Vector3 newCameraDirection = portalRotaionalDifference * playerCam.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
    }


}