using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoints> path = new List<Waypoints>();
    [SerializeField] float waithTime;
    private void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        foreach(Waypoints waypoints in path)
        {
            transform.position = waypoints.transform.position;
            yield return new WaitForSeconds(waithTime);
        }
    }
}
