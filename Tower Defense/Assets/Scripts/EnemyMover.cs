using UnityEngine;
using System.Collections.Generic;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoints> path = new List<Waypoints>();
    private void Start()
    {
        PrintWaypointsName();
    }

    private void PrintWaypointsName()
    {
        foreach(Waypoints waypoints in path)
        {
            Debug.Log(waypoints.name);
        }
    }
}
