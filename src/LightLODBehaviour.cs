﻿// Decompiled with JetBrains decompiler
// Type: LightLODBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
