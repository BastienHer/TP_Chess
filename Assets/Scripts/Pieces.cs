using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PieceType
{
    PAWN,
    BISHOP,
    KNIGHT,
    ROCK,
    QUEEN,
    KING
}
[System.Serializable]
public class Pieces
{
    public PieceType pieceType;


}
