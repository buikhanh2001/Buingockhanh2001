using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypont : MonoBehaviour
{
    [SerializeField] private GameObject[] wayponts;
    private int currentWaypontIndex = 0;

    [SerializeField] private float speed = 2f;

    // Update is called once per frame
    private void Update()
    {
        if (Vector2.Distance(wayponts[currentWaypontIndex].transform.position, transform.position) < .1f)
        {
            currentWaypontIndex++;
            if(currentWaypontIndex >= wayponts.Length)
            {
                currentWaypontIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, wayponts[currentWaypontIndex].transform.position, Time.deltaTime * speed);
    }
}
