using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targets : MonoBehaviour
{
    public static GameObject newObj;
    public static GameObject col;
    public GameObject newo;
    

    // Start is called before the first frame update
    void Start()
    {
        col = GameObject.FindGameObjectWithTag("ShotArea");

        if (!newObj)
        {
            newObj = newo;
            
            newObj.name = "Crystal";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void destroyed()
    {
        
        Vector3 origin = col.transform.position;
        Vector3 range = col.transform.localScale / 2.0f;
        Vector3 randomRange = new Vector3(  Random.Range(-range.x, range.x),
                                            Random.Range(-range.y, range.y),
                                            Random.Range(-range.z, range.x));
        Vector3 coordenate = origin + randomRange;
        Instantiate(newObj, coordenate, Quaternion.identity);

    }
}
