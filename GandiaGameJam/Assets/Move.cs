using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float velocidad = 5f;

    void Update()
    {
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
    }
}
