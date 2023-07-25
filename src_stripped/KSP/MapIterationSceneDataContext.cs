﻿// Decompiled with JetBrains decompiler
// Type: KSP.MapIterationSceneDataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using KSP.Map;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;

namespace KSP
{
  public class MapIterationSceneDataContext : DebugUIContextInstanced
  {
    public MapItemType mapItemType;
    public ContextBindRoot entryBindRoot;
    private MapItemType lastItemType;
    private Property<MapItemType> itemTypes;
    private string typeKey;

    private IDataContext TestDataContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapIterationSceneDataContext() => throw null;
  }
}
