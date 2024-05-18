using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementManager : MonoBehaviour
{
    public int width, height;
    Grip placementGrip;

    private void Start()
    {
        placementGrip = new Grip(width, height);
    }

    internal bool CheckIfPositionInBound(Vector3Int position)
    {
        if(position.x >= 0 && position.x < width && position.z >= 0 && position.z < height)
        {
            return true;
        }
        return false;
    }

    internal bool CheckIfPositionIsFree(Vector3Int position)
    {
        return CheckIfPositionIsOfType(position, CellType.Empty);
    }

    private bool CheckIfPositionIsOfType(Vector3Int position, CellType type)
    {
        return placementGrip[position.x, position.z] == type;
    }

    internal void PlaceTemporaryStructure(Vector3Int position, GameObject roadStraight, CellType type)
    {
        placementGrip[position.x, position.z] = type;
        GameObject newStructure = Instantiate(roadStraight, position, Quaternion.identity);
    }
    // public int width, height;
    // Grip placementGrip;

    // private Dictionary<Vector3Int, StructureModel> temporaryRoadobjects = new Dictionary<Vector3Int, StructureModel>();

    // private void Start()
    // {
    //     placementGrip = new Grip(width, height);
    // }

    // internal CellType[] GetNeighbourtTypesFor(Vector3Int position)
    // {
    //     return placementGrip.GetAllAdjacentCellTypes(position.x, position.z);
    // }

    // internal bool CheckIfPositionInBound(Vector3Int position)
    // {
    //     if(position.x >=0  && position.x < width && position.z >= 0 && position.z < height)
    //     {
    //         return true;
    //     }
    //     return false;
    // }

    // internal bool CheckIfPositionIsFree(Vector3Int position)
    // {
    //     return CheckIfPositionIsOfType(position, CellType.Empty);
    // }

    // private bool CheckIfPositionIsOfType(Vector3Int position, CellType type)
    // {
    //     return placementGrip[position.x, position.z] == type;
    // }

    // internal void PlaceTemporaryStructure(Vector3Int position, GameObject roadStraight, CellType type)
    // {
    //     placementGrip[position.x, position.z] = type;
    //     GameObject newStructure = Instantiate(roadStraight, position, Quaternion.identity);
    //     // StructureModel structure = CreateANewStructureModel(position, structurePrefab, type);
    //     // temporaryRoadobjects.Add(position, structure);
    }


