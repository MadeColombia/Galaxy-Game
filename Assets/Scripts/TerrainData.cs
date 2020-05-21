using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TerrainData",menuName = "TerrainData")]
public class TerrainData : ScriptableObject
{
    public List<GameObject> posibleTerreno;
    public int maxEnFila;
}
