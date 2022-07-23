using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float DestoryDelay;
    SpriteRenderer spriteRenderer;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Package is Picked up");
            hasPackage = true;
            Destroy(collision.gameObject, DestoryDelay);
            spriteRenderer.color = hasPackageColor;
        }
        if (collision.CompareTag("Location") && hasPackage)
        {
            Debug.Log("Package is Delivered");
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
    }
}
