using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Transform transform;
    public float shakeDuration;
    public float shakeMagnitude;
    public float dampingSpeed;
    Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shakeDuration > 0)
        {
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;
            shakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else {
            shakeDuration = 0f;
            transform.localPosition = initialPosition;
        }
    }

    void Awake() {
        if (transform == null) {
            transform = GetComponent(typeof(Transform)) as Transform;
        }
    }

    void OnEnable() {
        initialPosition = transform.localPosition;
    }
}
