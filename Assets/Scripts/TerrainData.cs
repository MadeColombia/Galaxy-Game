using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TerrainData",menuName = "TerrainData")]
public class TerrainData : ScriptableObject
{
    public GameObject terreno;
    public int maxEnFila;
}
