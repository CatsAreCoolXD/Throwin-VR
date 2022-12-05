using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public TextMeshPro ballsText;
    private float balls = 1f;
    private void Start()
    {
        balls = PlayerPrefs.GetFloat("AmountOfBalls", 1f);
        if (PlayerPrefs.GetFloat("LimitedBalls", 1f) == 1f)
        {
            ballsText.text = "Balls: " + balls.ToString();
        } else
        {
            ballsText.text = "Balls: Infinite";
        }
    }
    public void SetLimitedBalls()
    {
        PlayerPrefs.SetFloat("LimitedBalls", 1f);
        ballsText.text = "Balls: " + balls.ToString();
    }
    public void SetUnlimitedBalls()
    {
        PlayerPrefs.SetFloat("LimitedBalls", 0f);

        ballsText.text = "Balls: Infinite";
        Debug.Log("Unlimited Balls");
    }
    public void IncreaseBalls()
    {
        if (PlayerPrefs.GetFloat("LimitedBalls", 0f) == 1)
        {
            balls += 1;
            ballsText.text = "Balls: " + balls.ToString();
            PlayerPrefs.SetFloat("AmountOfBalls", balls);
        }
    }
    public void DecreaseBalls()
    {
        if (balls > 1f && PlayerPrefs.GetFloat("LimitedBalls", 0f) == 1f)
        {
            balls -= 1;
            ballsText.text = "Balls: " + balls.ToString();
            PlayerPrefs.SetFloat("AmountOfBalls", balls);
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
