using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField]
    private float _impulse;
    private Rigidbody2D _body;
    private bool _isGrounded = true;

    private void Awake()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && _isGrounded) 
        {
            transform.SetParent(null);
            //_body.AddForce(transform.up * _impulse);
            _body.AddForce(new Vector2(Random.Range(-800, 800), _impulse));
            _isGrounded = !_isGrounded;
        }
    }
}
