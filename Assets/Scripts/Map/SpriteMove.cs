using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x -= _moveSpeed * Time.deltaTime;
        transform.position = newPosition;
    }
}
