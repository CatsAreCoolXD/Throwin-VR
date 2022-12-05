using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoringSystem : MonoBehaviour
{
    public TextMeshPro scoreText;

    public float score = 0f;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void increaseScore(float target)
    {
        score += target;
        scoreText.text = "Score: " + score.ToString();
    }
    public void toMenu()
    {
        SceneManager.LoadScene("VRMenu");
    }
}
