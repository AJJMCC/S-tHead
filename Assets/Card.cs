using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public enum SuitEnum
    {
        Hearts = 1,
        Clubs = 2,
        Diamonds = 3,
        Spades = 4,
    }

public enum RankEnum
{
    two = 2,
    three = 3,
    four = 4,
    five = 5,
    six = 6,
    seven = 7,
    eight = 8,
    nine = 9,
    ten = 10,
    jack = 11,
    queen = 12,
    king = 13,
    ace = 14
}


public class Card : MonoBehaviour
{
    public SuitEnum Suit;

    public RankEnum Rank;
    private float OurRank;

    public bool IsSelected;
    void Start()
    {

    }


    void Update()
    {

    }



     
}
