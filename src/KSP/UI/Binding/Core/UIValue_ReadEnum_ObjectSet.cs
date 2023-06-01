﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValue_ReadEnum_ObjectSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  public class UIValue_ReadEnum_ObjectSet : UIValueEnumBinder
  {
    [SerializeField]
    private GameObject[] targetObjects;
    [Header("Choose active for each object")]
    [SerializeField]
    private UIValue_ReadEnum_ObjectSet.ObjectEntry[] objectValues;
    [Header("Fallback - used when value is not mapped")]
    [SerializeField]
    private UIValue_ReadEnum_ObjectSet.FallbackEntry fallbackValue;
    protected Dictionary<string, UIValue_ReadEnum_ObjectSet.ObjectEntry> valueMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void PopulateValueMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetObjectsActive(bool isActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadEnum_ObjectSet() => throw null;

    [Serializable]
    public struct ObjectEntry
    {
      public string enumValue;
      public bool active;

      public static UIValue_ReadEnum_ObjectSet.ObjectEntry Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct FallbackEntry
    {
      public bool active;

      public static UIValue_ReadEnum_ObjectSet.FallbackEntry Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
