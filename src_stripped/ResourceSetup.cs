﻿// Decompiled with JetBrains decompiler
// Type: ResourceSetup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Obsolete("Exposes instance via singleton which is obsolete in most cases")]
public class ResourceSetup : MonoBehaviour
{
  private static ResourceSetup instance;
  private static ResourceSetup.ResourceConfig _resConfig;

  [Obsolete("Exposes instance via singleton which is obsolete in most cases", true)]
  public static ResourceSetup Instance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  public ResourceSetup.ResourceConfig ResConfig
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private ResourceSetup.ResourceConfig LoadResourceConfig() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ResourceSetup() => throw null;

  public class ResourceConfig
  {
    public bool HeatEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int ECMinScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int OverlayStyle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool ShowDebugOptions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceConfig() => throw null;
  }
}
