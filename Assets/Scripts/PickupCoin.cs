using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCoin : MonoBehaviour
{
    public GameObject prefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Coin")
        {
            GameObject go = Instantiate(prefab, other.transform.position, Quaternion.identity);
            Destroy(go, 1);
            Destroy(other.gameObject);

        }
    }
}
