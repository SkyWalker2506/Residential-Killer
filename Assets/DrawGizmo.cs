using UnityEngine;

public class DrawGizmo: MonoBehaviour
{
    private void Awake()
    {
        Debug.Log(gameObject.name);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, new Vector3(1, 1, 1));
    }
}