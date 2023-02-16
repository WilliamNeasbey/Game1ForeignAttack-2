using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolPoints : MonoBehaviour
{
    public Transform[] waypoints;
    public int n = 0;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, waypoints[n].position);

        if (distance < Mathf.Epsilon)
        {
            ++n;
            n %= waypoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[n].position, speed * Time.deltaTime);
    }
}
