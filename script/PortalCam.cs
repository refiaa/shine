using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCam : MonoBehaviour
{
    public Transform PlayerCam;
    public Transform PT;
    public Transform OtherPT;

    void Update()
    {
        Vector3 PlayerOffsetFromPortal = PlayerCam.position - OtherPT.position;
        transform.position = PT.position + PlayerOffsetFromPortal;

        float angularDifferenceBetweenPortalRotaion = Quaternion.Angle(PT.rotation, OtherPT.rotation);

        Quaternion PortalRotaionalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotaion, Vector3.up);
        Vector3 newCameraDirection = PortalRotaionalDifference * PlayerCam.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
    }


}