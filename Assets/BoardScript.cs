using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour
{
    public GameObject dicePrefab;

    public float diceOffset = 2;

    Dictionary<BoardPosition, GameObject> dice = new Dictionary<BoardPosition, GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        foreach (var boardPosition in GetBoardPositions(2))
        {
            if (boardPosition == new BoardPosition(0, 0))
            {
                continue;
            }
            dice.Add(boardPosition, CreateDice(boardPosition));
        }
    }

    // Method that generates all board positions for a range of coordinates
    public IEnumerable<BoardPosition> GetBoardPositions(int max)
    {
        for (int x = 0; x <= max; x++)
        {
            for (int y = 0; y <= max; y++)
            {
                yield return new BoardPosition(x, y);
            }
        }
    }

    public GameObject CreateDice(BoardPosition boardPosition)
    {
        return Instantiate(dicePrefab, transform.position + new Vector3(boardPosition.X * diceOffset, boardPosition.Y * diceOffset, 0), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // myDice.GetComponent<DiceScript>().RotateLeft();
        }
    }
}
