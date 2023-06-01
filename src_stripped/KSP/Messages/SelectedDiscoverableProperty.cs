﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.SelectedDiscoverableProperty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages.PropertyWatchers;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Messages
{
  [Serializable]
  public struct SelectedDiscoverableProperty
  {
    [SerializeField]
    private string _discoveryName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SelectedDiscoverableProperty(string propertyDiscoveryName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SelectedDiscoverableProperty(System.Type discoverablePropertyType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeForType<T>() where T : PropertyWatcher, new() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public System.Type GetStoredType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SelectedDiscoverableProperty CreateFor<T>() where T : PropertyWatcher, new() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SelectedDiscoverableProperty CreateFor(string discoveryName) => throw null;
  }
}
