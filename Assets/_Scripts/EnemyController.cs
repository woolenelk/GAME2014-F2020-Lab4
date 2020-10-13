using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBounds;
    public float direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0, 0);
    }

    private void _CheckBounds()
    {
        if (transform.position.x >= horizontalBounds)
        {
            direction = -1.0f;
        }
        if (transform.position.x <= -horizontalBounds)
        {
            direction = 1.0f;
        }
    }
}
