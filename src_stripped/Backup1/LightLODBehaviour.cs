﻿// Decompiled with JetBrains decompiler
// Type: LightLODBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LightLODBehaviour : KerbalMonoBehaviour
{
  public Light PointLight;
  public MeshRenderer LightQuad;
  private LightCullingManager _lightCullingManager;
  private int _index;
  private Transform _thisTransform;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LightLODBehaviour() => throw null;
}
