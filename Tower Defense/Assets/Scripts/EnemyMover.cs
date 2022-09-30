using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoints> path = new List<Waypoints>();
    [SerializeField] [Range(0f, 5f)] float speed;

    private void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        foreach(Waypoints waypoints in path)
        {
            Vector3 startPosition = transform.position;
            Vector3 endPosition = waypoints.transform.position;
            float travelPercent = 0f;

            transform.LookAt(endPosition);

            while(travelPercent < 1f)
            {
                travelPercent += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(startPosition, endPosition, travelPercent);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
