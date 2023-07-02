﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Data.impl.ScriptableObjectAssetDatabase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Data.impl
{
  [CreateAssetMenu(fileName = "assetdatabase.asset", menuName = "KSP/Asset Database")]
  public class ScriptableObjectAssetDatabase : ScriptableObject
  {
    public List<GameObject> controllerPrefabs;
    private Dictionary<string, GameObject> controllerDatabase;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject GetPrefabByKey(string assetKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICollection<string> GetKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StorePrefab(string key, GameObject prefab) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptableObjectAssetDatabase() => throw null;
  }
}
