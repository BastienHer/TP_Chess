using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPlateGenerator : MonoBehaviour
{
    public GameObject WhiteBox, BlackBox;
    public GameObject[] WhitePrefab, BlackPrefab;
    public PieceCoord[] whitePieces,blackPieces;
    public Vector2Int PlateDimension;
    private Vector2 _whiteBoxDimension, _blackBoxDimension;
    private Vector2 _plateOffset;
    public static ChessPlateGenerator Instance;
    public List<List<Box>> BoxesArray = new List<List<Box>>();
    private void Awake()
    {
        if (Instance == null) {
            Instance = this;
        }
        _whiteBoxDimension = WhiteBox.GetComponent<SpriteRenderer>().size * WhiteBox.transform.localScale;
        _blackBoxDimension = BlackBox.GetComponent<SpriteRenderer>().size * BlackBox.transform.localScale;
        _plateOffset = PlateDimension / 4 * (_whiteBoxDimension + _blackBoxDimension);
        GeneratePlate(PlateDimension, _whiteBoxDimension, _blackBoxDimension);
        GenerateWhitePiece(whitePieces);
        GenerateBlackPiece(blackPieces);
    }
    void Start()
    {

    }
    void GeneratePlate(Vector2Int plateDimension, Vector2 _whiteBoxDimension, Vector2 _blackBoxDimension)
    {
        for(int i = 0; i < plateDimension.x; i++)
        {
            for(int j =0; j< plateDimension.y; j++)
            {
                bool isWhite = (i + j)%2==0;
                GameObject box = Instantiate( isWhite?WhiteBox:BlackBox, transform);
                Vector2 boxDimension = isWhite?_whiteBoxDimension:_blackBoxDimension;
                box.transform.position = new Vector2(i*boxDimension.x-_plateOffset.x, j*boxDimension.y-_plateOffset.y);
            }
        }
    }
    void GenerateWhitePiece(PieceCoord[] piecesCoords)
    {
        for (int i=0;i<piecesCoords.Length;i++) 
        {
            PieceType pieceTypeToPlace = piecesCoords[i].piece.pieceType;
            int type = (int)pieceTypeToPlace;
            GameObject pieceToPlace = Instantiate(WhitePrefab[type]);
            pieceToPlace.transform.position = new Vector2(piecesCoords[i].coords.x *_whiteBoxDimension.x - _plateOffset.x, piecesCoords[i].coords.y * _whiteBoxDimension.y - _plateOffset.y);
        }
    }
    void GenerateBlackPiece(PieceCoord[] piecesCoords)
    {
        for (int i = 0; i < piecesCoords.Length; i++)
        {
            PieceType pieceTypeToPlace = piecesCoords[i].piece.pieceType;
            int type = (int)pieceTypeToPlace;
            GameObject pieceToPlace = Instantiate(BlackPrefab[type]);
            pieceToPlace.transform.position = new Vector2(piecesCoords[i].coords.x * _whiteBoxDimension.x - _plateOffset.x, piecesCoords[i].coords.y * _whiteBoxDimension.y - _plateOffset.y);
        }
    }

    void Update()
    {
        
    }
}
