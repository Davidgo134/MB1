using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainOptimizer : MonoBehaviour
{
    public Terrain terrain;                     // Ссылка на террейн
    public TreePrototype[] treePrototypes;       // Массив с оригинальными деревьями
    public DetailPrototype[] detailPrototypes;   // Массив с оригинальными деталями (травой)

    public int maxTrees = 500;                   // Максимальное количество деревьев
    public int maxDetails = 500;                 // Максимальное количество деталей (травы)

    private void Start()
    {
        // Устанавливаем новые значения максимального количества деревьев и деталей
        terrain.terrainData.treeInstances = ReduceTrees(maxTrees);
        terrain.terrainData.detailPrototypes = ReduceDetails(maxDetails);
    }

    private TreeInstance[] ReduceTrees(int newCount)
    {
        TreeInstance[] originalTrees = terrain.terrainData.treeInstances;
        
        // Меняем количество деревьев на земле
        TreeInstance[] reducedTrees = new TreeInstance[newCount];
        for (int i = 0; i < newCount; i++)
        {
            reducedTrees[i] = originalTrees[i]; // Копируем только нужное количество деревьев
        }
        
        return reducedTrees;
    }

    private DetailPrototype[] ReduceDetails(int newCount)
    {
        DetailPrototype[] originalDetails = terrain.terrainData.detailPrototypes;
        
        // Меняем количество деталей на земле (травы)
        DetailPrototype[] reducedDetails = new DetailPrototype[newCount];
        for (int i = 0; i < newCount; i++)
        {
            reducedDetails[i] = originalDetails[i]; // Копируем только нужное количество деталей
        }
        
        return reducedDetails;
    }
}