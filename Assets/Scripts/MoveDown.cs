using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 1.0f;
 
    private Rigidbody enemyRb;
    
    private float zDestroy = -10.0f;

    // Start is called before the first frame update
    private void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        enemyRb.AddForce(Vector3.forward * -speed, ForceMode.Impulse);
        
        if (transform.position.z < zDestroy) 
        {
            Destroy(gameObject);
        }
    }
}
