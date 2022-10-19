using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    public Vector3 offset;
    public Transform Player1;
    [Range (0, 1)] public float lerpValue;
    public float sensibilidad;

    void start()
    {
        Player1 = GameObject.Find("Player").transform;
    }

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Player1.position + offset, lerpValue);
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensibilidad, Vector3.up) * offset;

        transform.LookAt(Player1);

    }
}
