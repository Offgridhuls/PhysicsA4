using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public CharacterController m_CharacterController;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = m_CharacterController.transform.position;
                bullet.transform.rotation = m_CharacterController.transform.rotation;
                bullet.SetActive(true);
            }//do stuff
        }
    }
}
