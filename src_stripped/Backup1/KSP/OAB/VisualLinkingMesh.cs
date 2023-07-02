﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.VisualLinkingMesh
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class VisualLinkingMesh : KerbalMonoBehaviour
  {
    public GameObject toDeform;
    public Transform start;
    public Transform end;
    [Range(0.0f, 2f)]
    public float width;
    private bool selfDestructing;
    private Vector3 lastStart;
    private Vector3 lastEnd;
    private ObjectAssemblyBuilderEvents builderEvents;

    public Vector3 LinkStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 LinkEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ObjectAssemblyBuilderEvents builderEvents) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePositioning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VisualLinkingMesh() => throw null;
  }
}
