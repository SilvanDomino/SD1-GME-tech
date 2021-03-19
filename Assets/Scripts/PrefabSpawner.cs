using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(prefab, new Vector3(0, 7, 0), Quaternion.identity);
            Destroy(go, 3.0f);
            go.name = "Bullet-ish object";
            Rigidbody rb = go.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(10, 0, 0);
        }
    }
}
