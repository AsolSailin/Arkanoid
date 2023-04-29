using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBallMove : MonoBehaviour
{
    [SerializeField]
    private float _impulse;
    private Rigidbody2D _body;

    private void Awake()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        _body.AddForce(new Vector2(Random.Range(-800, 800), _impulse));
    }
}
