using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour
{
    private Rigidbody rb;
    private float spawnedBalls = 1f;
    private bool didSpawnBalls = false;
    public GameObject defaultBall;
    public BoxCollider coll;
    private void Start()
    {
        if (PlayerPrefs.GetFloat("LimitedBalls", 1f) == 0f)
        {
            CloneBall(defaultBall);
            CloneBall(defaultBall);
            CloneBall(defaultBall);
            CloneBall(defaultBall);
            spawnedBalls = 5f;
        }
    }
    public void CloneBall(GameObject other)
    {
        GameObject ballClone = Instantiate(other);
        Destroy(other);
        rb = ballClone.GetComponent<Rigidbody>();
        ballClone.transform.position = new Vector3(-13.48f, 3.5f, 2.41f);
    }
    private void OnTriggerEnter(Collider other)
    {
        CloneBall(other.gameObject);
    }
    void Update()
    {
        var a = 0f;
        foreach (GameObject ball in GameObject.FindGameObjectsWithTag("Ball"))
        {
            a += 1;
            if (ball.transform.position.y < -5 && PlayerPrefs.GetFloat("LimitedBalls", 1f) == 0f)
            {
                Debug.Log("Spawn Ball");
                CloneBall(ball);
            }
        }
        spawnedBalls = a;
        if (PlayerPrefs.GetFloat("LimitedBalls", 1f) == 1f && !didSpawnBalls)
        {
            if (spawnedBalls-1 < PlayerPrefs.GetFloat("AmountOfBalls", 0f))
            {
                GameObject ballClone = Instantiate(defaultBall);
                ballClone.transform.position = new Vector3(1f, 1f, 1f);
            }
        }
        if (spawnedBalls-1 == PlayerPrefs.GetFloat("AmountOfBalls", 0f))
        {
            didSpawnBalls = true;
        }
    }
}
