using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    DicePosition dicePosition = new DicePosition(1, 6, 3, 4, 2, 5);

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = sprites[dicePosition.Top - 1];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
