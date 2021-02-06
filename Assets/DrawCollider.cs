using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCollider : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.AddComponent<DrawGizmo>();
    }
}
