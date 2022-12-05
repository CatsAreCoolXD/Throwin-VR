using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHole : MonoBehaviour
{
    public float targetScore;
    public ScoringSystem score;

    private void OnTriggerEnter(Collider other)
    {
        score.increaseScore(targetScore);
    }
}
