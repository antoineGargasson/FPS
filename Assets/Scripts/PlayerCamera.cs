using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private Transform playerTransform { get; set; } = null;

    public Transform _eyeTransform = null;

    private Transform eyeTransform { get { return _eyeTransform; } set { _eyeTransform = value; } }

    //variable
    public bool _invertCamera = false;

    //propri�t�
    private bool invertCamera { get { return _invertCamera; } set { _invertCamera = value; } }

    private void Start()
    {
        playerTransform = transform;
    }
    
    private void Update()
    {
        playerTransform.Rotate(Vector3.up, Input.GetAxis("Mouse X"));
        float invertValue = invertCamera == true ? 1 : -1;
        eyeTransform.Rotate(Vector3.right, Input.GetAxis("Mouse Y") * invertValue);
    }
}
