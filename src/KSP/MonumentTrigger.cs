﻿// Decompiled with JetBrains decompiler
// Type: KSP.MonumentTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP
{
  public class MonumentTrigger : MonoBehaviour
  {
    public float EmissiveMax;
    public float sequenceLength;
    public string shaderName;
    public string emissivePropertyName;
    [SerializeField]
    private Collider triggerCollider;
    private List<Material> emmissiveMatList;
    private CutsceneTools.CutsceneDefinition localCutscene;

    private IViewController viewController
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartMonumentActivation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetMonumentActivation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateMaterialListByShader(string shaderName, out List<Material> rendererList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator UpdateMaterialCoroutine(List<Material> materialList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MonumentTrigger() => throw null;
  }
}
