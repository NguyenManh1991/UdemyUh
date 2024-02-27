using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float deleyTimer;
    bool hasPackage;
    SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("g");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package"&& !hasPackage)
        {
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Debug.Log(spriteRenderer.color);
            Destroy(other.gameObject,deleyTimer);
            Debug.Log("Da nhan hang");
        }
        if (other.tag == "Unpackage"&& hasPackage==true)
        {
            Debug.Log("Hang Da duoc giao");
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
    }
}
