﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Effects/Damage", 2)]
  public class VPDamage : VehicleBehaviour
  {
    public MeshFilter[] meshes;
    public MeshCollider[] colliders;
    public Transform[] nodes;
    [Space(5f)]
    public float minVelocity;
    public float multiplier;
    [Space(5f)]
    public float damageRadius;
    public float maxDisplacement;
    public float maxVertexFracture;
    [Space(5f)]
    public float nodeDamageRadius;
    public float maxNodeRotation;
    public float nodeRotationRate;
    [Space(5f)]
    public float vertexRepairRate;
    public bool enableRepairKey;
    public KeyCode repairKey;
    private Vector3[][] m_originalMeshes;
    private Vector3[][] m_originalColliders;
    private Vector3[] m_originalNodePositions;
    private Quaternion[] m_originalNodeRotations;
    private bool m_repairing;
    private float m_meshDamage;
    private float m_colliderDamage;
    private float m_nodeDamage;

    public bool isRepairing
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float meshDamage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float colliderDamage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float nodeDamage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Repair() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessImpact() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float DeformMesh(
      Mesh mesh,
      Vector3[] originalMesh,
      Transform localTransform,
      Vector3 contactPoint,
      Vector3 contactVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float DeformNode(
      Transform T,
      Vector3 originalLocalPos,
      Quaternion originalLocalRot,
      Vector3 contactPoint,
      Vector3 contactVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 AnglesToVector(Vector3 Angles) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float DeformColliders(Vector3 contactPoint, Vector3 impactVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessRepair() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool RepairMesh(
      Mesh mesh,
      Vector3[] originalMesh,
      float repairRate,
      float repairedThreshold)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool RepairNode(
      Transform T,
      Vector3 originalLocalPosition,
      Quaternion originalLocalRotation,
      float repairRate,
      float repairedThreshold)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RestoreMeshes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RestoreNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RestoreColliders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPDamage() => throw null;
  }
}
