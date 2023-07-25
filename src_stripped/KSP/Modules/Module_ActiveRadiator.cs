﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_ActiveRadiator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_ActiveRadiator : Module_Cooler
  {
    [SerializeField]
    protected Data_ActiveRadiator dataActiveRadiator;
    private Data_Deployable _dataDeployable;
    private DragCubeGenerator _dragCubeGenerator;
    private Module_ProceduralPart _moduleProceduralPart;
    private Data_ProceduralPart _dataProceduralPart;
    private Vector3 radiatorVector;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsProceduralPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnBeforeSetStatusString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void MeshDataChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateMeshAreaAsync(
      GameObject gameObj,
      Data_LiftingSurface.TransformDir radiatorDirection)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCompletDragCubeCalculation(DragCube cube) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_ActiveRadiator() => throw null;
  }
}
