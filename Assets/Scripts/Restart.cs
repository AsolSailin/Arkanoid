using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    [SerializeField]
    private Button _button;

    private void Start()
    {
        _button.onClick.AddListener(Click);
    }
    public void Click()
    {
        SceneManager.LoadScene(0);
        GameOver.countBalls++;
        Time.timeScale = 1.0f;
    }
}
