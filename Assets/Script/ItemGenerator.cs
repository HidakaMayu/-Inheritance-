using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject[] ItemPrefabs;
    private int number;
    float span = 1.0f;
    float dalta = 0;

    void Update()
    {
        this.dalta += Time.deltaTime;
        if (this.dalta > this.span)
        {
            this.dalta = 0;
            int px = Random.Range(-6, 7);
            int rd = Random.Range(0, 4);
            Instantiate(ItemPrefabs[rd], new Vector3(px, 7, 0), Quaternion.identity);
        }
    }
}




