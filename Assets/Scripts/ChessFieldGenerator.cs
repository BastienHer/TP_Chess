//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


//public class ChessFieldGenerator : MonoBehaviour
//{
//    void Start()
//    {

//        for(int j = 0;j< ChessPlateGenerator.Instance.PlateDimension.y / 2; j++)
//        {
//            if (j < pieces.Length)
//            {
//                Pieces piece = pieces[j];
//                for (int i = 0; i < ChessPlateGenerator.Instance.PlateDimension.x / 2; i++)
//                {
//                    Debug.Log(ChessPlateGenerator.Instance.PlateDimension.x / 2);
//                    GameObject PieceToPlace = SelectPieceToPlace(piece.pieceType[i]);
//                    if (PieceToPlace)
//                    {
                        
//                        Box boxDestination = ChessPlateGenerator.Instance.BoxesArray[i][j];
//                        GameObject InstantiatePiece = Instantiate(PieceToPlace,boxDestination.transform);

//                    }
//                }
//            } 
//        }
//    }

//    }
//    void Update()
//    {
        
//    }
//}
