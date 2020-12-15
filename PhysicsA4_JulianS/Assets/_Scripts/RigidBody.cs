using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class RigidBody : MonoBehaviour
{
    public struct m_rigidbody
    {
        public float mass;
        public Vector3 velocity;
        public Vector3 acceleration;
        public bool isColliding;
    }

}
