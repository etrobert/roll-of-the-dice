using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour
{
    public GameObject dicePrefab;

    GameObject myDice;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        myDice = Instantiate(dicePrefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myDice.GetComponent<DiceScript>().RotateLeft();
        }
    }
}
