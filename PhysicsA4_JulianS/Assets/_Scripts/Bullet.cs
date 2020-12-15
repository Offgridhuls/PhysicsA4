using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Color = UnityEngine.Color;
[System.Serializable]
public class Bullet : MonoBehaviour
{
    public Vector3 max;
    public Vector3 min;
    public Vector3 size;
    public RigidBody.m_rigidbody rigidBody = new RigidBody.m_rigidbody();
    private MeshFilter meshFilter;
    private Bounds bounds;
    public bool isColliding;
    public List<Bullet> contacts;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody.velocity = transform.forward * 200;
        Debug.Log(rigidBody.velocity);
        meshFilter = GetComponent<MeshFilter>();

        bounds = meshFilter.mesh.bounds;
        size = bounds.size;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += rigidBody.velocity * Time.deltaTime;
        max = Vector3.Scale(bounds.max, transform.localScale) + transform.position;
        min = Vector3.Scale(bounds.min, transform.localScale) + transform.position;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;

        Gizmos.DrawWireCube(transform.position, Vector3.Scale(new Vector3(1.0f, 1.0f, 1.0f), transform.localScale));
    }
}
