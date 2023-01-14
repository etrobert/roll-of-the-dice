using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour
{
    public GameObject dicePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        Instantiate(dicePrefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
