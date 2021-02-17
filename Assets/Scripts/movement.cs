using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float velocidadR = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        velocidadR = 20.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, velocidadR * Time.deltaTime, 0);
    }
}
