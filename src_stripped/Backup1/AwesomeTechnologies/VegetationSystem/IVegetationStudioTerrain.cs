﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.IVegetationStudioTerrain
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Vegetation;
using AwesomeTechnologies.VegetationSystem.Biomes;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public interface IVegetationStudioTerrain
  {
    string TerrainType { get; }

    Bounds TerrainBounds { get; }

    float PolarSphereRadius { get; }

    float PolarSphereMaxHeight { get; }

    Vector3 PolarSpherePosition { get; }

    Transform PolarSphereTransform { get; }

    void RefreshTerrainData();

    void RefreshTerrainData(Bounds bounds);

    JobHandle SampleCellHeight(
      NativeArray<Bounds> vegetationCellBoundsList,
      float worldspaceHeightCutoff,
      Rect cellBoundsRect,
      JobHandle dependsOn = default (JobHandle));

    JobHandle SampleTerrain(
      NativeList<VegetationSpawnLocationInstance> spawnLocationList,
      VegetationInstanceData instanceData,
      int sampleCount,
      Rect spawnRect,
      float polarSphereRadius,
      JobHandle dependsOn);

    void SampleTerrainCompute(
      ComputeBuffer computeInstancesBuffer,
      int sampleCount,
      Rect spawnRect,
      float polarSphereRadius,
      HeightSampleMode heightSampleMode);

    void SampleProceduralTerrainTexture(
      ComputeBuffer computeInstancesBuffer,
      int sampleCount,
      Rect spawnRect,
      float polarSphereRadius,
      List<TerrainTextureRule> includeRules,
      List<TerrainTextureRule> excludeRules,
      bool useIncludeRules,
      bool useExcludeRules);

    void SampleConcaveLocationCompute(
      ComputeBuffer computeInstancesBuffer,
      int sampleCount,
      Rect spawnRect,
      float polarSphereRadius,
      float minHeightDifference,
      float distance,
      bool inverse,
      bool average);

    bool NeedsSplatMapUpdate(Bounds updateBounds);

    void PrepareSplatmapGeneration(bool clearLockedTextures);

    void GenerateSplatMapBiome(
      Bounds updateBounds,
      BiomeType biomeType,
      List<PolygonBiomeMask> polygonBiomeMaskList,
      List<TerrainTextureSettings> terrainTextureSettingsList,
      float heightCurveSampleHeight,
      float worldSpaceSeaLevel,
      bool clearLockedTextures);

    void CompleteSplatmapGeneration();

    JobHandle SampleConcaveLocation(
      VegetationInstanceData instanceData,
      float minHeightDifference,
      float distance,
      bool inverse,
      bool average,
      Rect spawnRect,
      JobHandle dependsOn);

    void Init();

    void DisposeTemporaryMemory();

    void OverrideTerrainMaterial();

    void RestoreTerrainMaterial();

    void VerifySplatmapAccess();

    void UpdateTerrainMaterial(
      float worldspaceSeaLevel,
      float worldspaceMaxTerrainHeight,
      TerrainTextureSettings terrainTextureSettings);

    JobHandle ProcessSplatmapRules(
      List<TerrainTextureRule> terrainTextureRuleList,
      VegetationInstanceData instanceData,
      bool include,
      Rect cellRect,
      JobHandle dependsOn);

    bool HasTerrainTextures();

    Texture2D GetTerrainTexture(int index);

    TerrainLayer[] GetTerrainLayers();

    void SetTerrainLayers(TerrainLayer[] terrainLayers);
  }
}
