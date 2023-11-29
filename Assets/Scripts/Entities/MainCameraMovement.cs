using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraMovement : MonoBehaviour
{
    [SerializeField] GameObject Target;
    private CharacterController _controller;
    private Vector2 _movementDirection = Vector2.zero;

    private Vector2 TargetPos;
    private float CameraSpeed = 10;

    private void Awake()
    {
        Debug.Log("awake 언제 나오나");
        _controller = GetComponent<CharacterController>();      
    }
    private void Start()
    {
        if(_controller!=null)
            _controller.OnMoveEvent += MoveCamera;
    }
    private void MoveCamera(Vector2 direction)
    {
        _movementDirection = direction;
    }
    private void ApplyCameraMovement(Vector2 direction)
    {
        transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.x,-10), Target.transform.position, Time.deltaTime*100);
        transform.Translate(0, 0, -10);
           
    }
    private void FixedUpdate()
    {
        ApplyCameraMovement(_movementDirection);
    }

}
