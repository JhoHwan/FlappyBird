using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Setting")]
    [SerializeField] [Range(1.0f, 10.0f)] private float _gravity;
    [SerializeField] [Range(1.0f, 10.0f)] private float _jumpForce;

    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Awake()
    {
        if(!TryGetComponent<Rigidbody2D>(out _rigidbody))
        {
            Debug.LogError("_rigidbody is null");
        }

        _rigidbody.gravityScale = _gravity;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    private void Jump()
    {
        _rigidbody.velocity = Vector3.up * _jumpForce;
    }
}
