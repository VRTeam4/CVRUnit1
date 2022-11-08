using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertValueToRotation : MonoBehaviour
{
    [Range(0, 1)] public float rotation = 0.0f;

    public GameObject pedestal;

    public void SetRotation(float rotation)
    {
        pedestal.transform.rotation = Quaternion.Euler(0, 360*rotation, 0);
    }
}
