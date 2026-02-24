using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Rigidbody2D _rb20;
    [SerializeField] private float x = 0;
    public float velocidad = 10f;

    private void Start()
    {

        //_transform.position = new Vector3(5f , 3.85f, 0);

    }

    private void FixedUpdate()
    {
        x = x + 0.1f;
        _rb20.velocity = Vector2.right * velocidad;
        // x = x + 0.1f;
       // _transform.position = new Vector3(x, 3.85f, 0f);
    }


}