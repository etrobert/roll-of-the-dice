using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    DiceOrientation diceOrientation = new DiceOrientation(1, 6, 3, 4, 2, 5);

    // Start is called before the first frame update
    void Start()
    {
        UpdateSprite();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateSprite()
    {
        spriteRenderer.sprite = sprites[diceOrientation.Top - 1];
    }

    public void RotateLeft() {
        diceOrientation = diceOrientation.RotateLeft();
        UpdateSprite();
    }

    public void RotateRight() {
        diceOrientation = diceOrientation.RotateRight();
        UpdateSprite();
    }

    public void RotateFront() {
        diceOrientation = diceOrientation.RotateFront();
        UpdateSprite();
    }

    public void RotateBack() {
        diceOrientation = diceOrientation.RotateBack();
        UpdateSprite();
    }
}
