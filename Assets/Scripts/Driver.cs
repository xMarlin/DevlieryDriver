using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speedOfRotation = 0f;
    [SerializeField] float MoveSpeed = 0.01f;
    [SerializeField] float SlowSpeed = 0f;
    [SerializeField] float BoostSpeed = 0.01f;
    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * speedOfRotation * Time.deltaTime;
        float Vertical = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount );
        transform.Translate(0, Vertical, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        MoveSpeed = SlowSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boost"))
        {
            MoveSpeed = BoostSpeed;
        }
    }
}
