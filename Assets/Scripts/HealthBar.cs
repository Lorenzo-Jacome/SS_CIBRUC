using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private Transform bar;
    public int takeDamage;
    public float health;

    void Start()
    {
        bar = transform.Find("Bar");
        health = 1f;
        //bar.localScale = new Vector3(0.2f, 1f);
        SetSize(health);
    }

    public void SetSize(float sizeNormalized) {
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }

    
}
