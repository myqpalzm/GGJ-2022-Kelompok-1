using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifetime : MonoBehaviour
{
    // Start is called before the first frame update
    public float lifetimeSeconds = 2.5f;
    void Start()
    {
        Destroy(gameObject, lifetimeSeconds);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
