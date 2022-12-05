using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBlocker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("LimitedBalls", 1f) == 0f) {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
