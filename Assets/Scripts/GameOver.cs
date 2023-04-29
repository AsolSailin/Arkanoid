using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject _canvas;
    public static int countBalls = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        countBalls--;
        Destroy(collision.gameObject);

        if (countBalls == 0)
        {
            Time.timeScale = 0.0f;
            _canvas.SetActive(true);
        }
    }
}
