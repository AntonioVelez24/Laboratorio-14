using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    private Transform _transform;
    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _transform.position = new Vector2(transform.position.x, _transform.position.y + speed * Time.deltaTime);
        if (transform.position.y <= 2)
        {
            speed = 0;
        }
    }
}
