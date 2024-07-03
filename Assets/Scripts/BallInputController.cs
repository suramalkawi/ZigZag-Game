using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class BallInputController : MonoBehaviour
{
    [HideInInspector] public Vector3 ballDirection;

    public GameObject menuElement;

    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;
    private int _score;


    void Start()
    {
        ballDirection = Vector3.zero;

    }

    void Update()
    {
        HandleBallInputs(); 
    }

    private void HandleBallInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeBallDirection();
            StartTheGame();
            
            _score++;
            _currentScoreText.text = _score.ToString();

        }
    }

    private void ChangeBallDirection()
    {


        if (ballDirection.x == -1)
        {
            ballDirection = Vector3.forward;
        }
        else
        {
            ballDirection = Vector3.left;
        }


    }
    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _highScoreText.text = _score.ToString();
        }
    }

    public void StartTheGame()
    {
        menuElement.SetActive(false);

    }

}
