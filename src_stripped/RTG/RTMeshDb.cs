﻿// Decompiled with JetBrains decompiler
// Type: RTG.RTMeshDb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class RTMeshDb : Singleton<RTMeshDb>
  {
    private Dictionary<Mesh, RTMesh> _meshes;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(RTMesh rtMesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(Mesh unityMesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMeshDirty(Mesh unityMesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RTMesh GetRTMesh(Mesh unityMesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMeshWillBeDestroyed(Mesh unityMesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private RTMesh CreateRTMesh(Mesh unityMesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RTMeshDb() => throw null;
  }
}
