using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleBlock : MonoBehaviour
{
    [SerializeField]
    private GameObject _platformBonusPrefab;
    [SerializeField]
    private GameObject _ballBonusPrefab;
    private int count;

    void OnCollisionEnter2D(Collision2D collision)
    {
        count++;

        if (count == 2)
        {
            Destroy(gameObject);
            var rnd = Random.Range(0, 3);

            if (rnd == 0)
            {
                var block = Instantiate(_platformBonusPrefab, transform.position, Quaternion.identity);
            }
            else if(rnd == 1)
            {
                var block = Instantiate(_ballBonusPrefab, transform.position, Quaternion.identity);
            }
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
