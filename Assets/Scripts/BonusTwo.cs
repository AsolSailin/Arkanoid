using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusTwo : MonoBehaviour
{
    [SerializeField]
    private GameObject _ballPrefab;
    [SerializeField]
    private float _impulse;
    private Rigidbody2D _body;

    private void Awake()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlatformMove platform))
        {
            GameOver.countBalls++;
            Destroy(gameObject);
            transform.position = new Vector3(0, -2, 0);
            Instantiate(_ballPrefab, transform.position, Quaternion.identity);
        }
    }
}
