using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] private BallDataTransmiter ballDataTransmiter;
    [SerializeField] private float ballMoveSpeed;
    public GameObject ps;

    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;
    private int _score;
    public AudioSource audio;
    public AudioClip encreaseClip;

    private void Start()
    {

        _currentScoreText.text = _score.ToString();
       // _highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();


    }

    private void Update()
    {
        SetBallMovement();

    }

    private void SetBallMovement()
    {
        transform.position += ballDataTransmiter.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pickup"))
        {
            audio.clip = encreaseClip;
            audio.Play();
            other.gameObject.SetActive(false);
           

            Instantiate(ps, transform.position, Quaternion.identity);

            _score += 3;
            _currentScoreText.text = _score.ToString();

        }

    }

    
    void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
                PlayerPrefs.SetInt("HighScore", _score);
                _highScoreText.text = _score.ToString();
         
        }
    }

}
