using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom_Puzzle_Solution : MonoBehaviour
{
    public int solutionID;
    public float tolerance = 0.2f;

    private Custom_Puzzle_Piece[] custom_Puzzle_Pieces;
    private Custom_Puzzle_Piece matchingPiece;

    private bool puzzleSolved = false;

    // Start is called before the first frame update
    void Start()
    {
        custom_Puzzle_Pieces = Object.FindObjectsByType<Custom_Puzzle_Piece>(FindObjectsSortMode.None);
        foreach (Custom_Puzzle_Piece p in custom_Puzzle_Pieces)
        {
            if(p.pieceID ==  solutionID)
            {
                matchingPiece = p; 
                break;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!puzzleSolved)
        {
            if (matchingPiece != null)
            {
                if (Vector3.Distance(matchingPiece.transform.position, this.gameObject.transform.position) < tolerance)
                {

                    XRF_RaycastInteractions_VRController[] controllers = Object.FindObjectsByType<XRF_RaycastInteractions_VRController>(FindObjectsSortMode.None);
                    foreach (XRF_RaycastInteractions_VRController controller in controllers)
                    {
                        controller.TriggerUnClick();
                    }

                    matchingPiece.gameObject.GetComponent<XRF_UPenn_InteractionController>().enabled = false;
                    matchingPiece.gameObject.GetComponent<XRF_UPenn_InteractionController>().isGrabbable = false;

                    //Destroy(matchingPiece.gameObject.GetComponent<XRF_UPenn_InteractionController>());


                    puzzleSolved = true;
                }
            }
        }
    }
}
