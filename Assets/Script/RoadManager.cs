using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public PlacementManager placementManager;

    public List<Vector3Int> temporaryPlacementPositions = new List<Vector3Int>();

    public GameObject roadStraight;

    public void PlaceRoad(Vector3Int position)
    {
        if(placementManager.CheckIfPositionInBound(position) == false)
            return;
        if(placementManager.CheckIfPositionIsFree(position) == false)       
            return;
        placementManager.PlaceTemporaryStructure(position, roadStraight, CellType.Road);
    }
//     public PlacementManager placementManager;
//     // public AudioPlayer audioPlayer;

//     public List<Vector3Int> temporaryPlacementPositions = new List<Vector3Int>();
//     public List<Vector3Int> roadPositionsToReCheck = new List<Vector3Int>();

//     private Vector3Int startPosition;
//     private bool placementmode = false;

//     public RoadFixer roadFixer;

//     public void Start()
//     {
//         roadFixer = GetComponent<RoadFixer>();
//     }

//     public void PlaceRoad(Vector3Int position)
//     {
//         if (placementManager.CheckIfPositionInBound(position) == false)
//             return;
//         if (placementManager.CheckIfPositionIsFree(position) == false)
//             return;
//         if (placementmode == false)
//         {
//             temporaryPlacementPositions.Clear();
//             roadPositionsToReCheck.Clear();

//             placementmode = true;
//             startPosition = position;

//             temporaryPlacementPositions.Add(position);
//             placementManager.PlaceTemporaryStructure(position, roadFixer.deadEnd, CellType.Road);
            
//         }
//         else
//         {
//             placementManager.RemoveAllTemporaryStructures();
//             temporaryPlacementPositions.Clear();
//             roadPositionsToReCheck.Clear();

//             temporaryPlacementPositions = placementManager.GetPathBetween(startPosition, position);

//             foreach (var temporaryPosition in temporaryPlacementPositions)
//             {
//                 placementManager.PlaceTemporaryStructure(temporaryPosition, roadFixer.deadEnd, CellType.Road);
//             }
//         }
//         FixRoadPrefabs();
//     }

//     private void FixRoadPrefabs()
//     {
//         foreach (var temporaryPosition in temporaryPlacementPositions)
//         {
//             roadFixer.FixRoadAtPosition(placementManager, temporaryPosition);
//             var neighbours = placementManager.GetNeighboursOfTypeFor(temporaryPosition, CellType.Road);
//             foreach (var roadposition in neighbours)
//             {
//                 if (roadPositionsToReCheck.Contains(roadposition)==false)
//                 {
//                     roadPositionsToReCheck.Add(roadposition);
//                 }
//             }
//         }
//         foreach (var roadPositionToFix in roadPositionsToReCheck)
//         {
//             roadFixer.FixRoadAtPosition(placementManager, roadPositionToFix);
//         }
//     }

//     public void FinishPlacingRoad()
//     {
//         placementmode = false;
//         if (temporaryPlacementPositions.Count > 0)
//         {
//             // audioPlayer.PlayPlacementSound();
//         }
//         temporaryPlacementPositions.Clear();
//         startPosition = Vector3Int.zero;
//     }
}
