using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    Vector2 _direction;

    private void Update()
    {
        _direction = Input.GetAxisRaw("Horizontal") * Vector2.right + Input.GetAxisRaw("Vertical") * Vector2.up;
    }

    private void FixedUpdate()
    {
        transform.parent.localPosition += (Vector3)_direction * _moveSpeed * Time.deltaTime;
    }

    private void Start()
    {
        _moveSpeed = 4;
    }
}
