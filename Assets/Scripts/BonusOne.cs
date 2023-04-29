using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusOne : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlatformMove platform))
        {
            Destroy(gameObject);
            collision.transform.localScale = new Vector2(1.0f, 1.0f);
        }
    }
}
