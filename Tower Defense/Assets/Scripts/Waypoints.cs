using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField] bool isPlaceable;

    private void OnMouseDown()
    {
        if (isPlaceable)
        {
            Debug.Log(transform.name);
        }
    }
}
