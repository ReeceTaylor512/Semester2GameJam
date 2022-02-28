using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public Rigidbody2D rb;
    private void Awake()
    {
        rb.AddForce(transform.right * 50, ForceMode2D.Impulse); 
    }
}
