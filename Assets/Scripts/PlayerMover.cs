using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private CharacterController _chController;
    private float _playerSpeed = 4f;
    private Transform _playerTransform;
    private Vector2 _directionVector;
    private void Start()
    {
        _chController = GetComponent<CharacterController>();
        _playerTransform = GetComponent<Transform>();
    }

    
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        _directionVector.x = Input.GetAxis("Horizontal") * _playerSpeed;
        _chController.Move(_directionVector * Time.deltaTime);
    }
}
