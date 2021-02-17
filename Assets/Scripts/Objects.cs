using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    AudioSource press;
    public float force = 0.0f;
    Rigidbody rb;

    
    MeshRenderer mesh;
    Color original;
    // Start is called before the first frame update
    void Start()
    {

        press = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();


        original = mesh.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {

        mesh.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        mesh.material.color = original;
    }

    private void OnMouseDown()
    {
        
        RaycastHit hitInfo;
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
       Physics.Raycast(camRay, out hitInfo);
        press.Play();
        rb.AddForce(-hitInfo.normal * 5, ForceMode.Impulse);
    }

}
