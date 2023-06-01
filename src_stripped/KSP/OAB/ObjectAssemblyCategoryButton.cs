﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyCategoryButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class ObjectAssemblyCategoryButton : MonoBehaviour
  {
    public PartCategories category;
    [SerializeField]
    private GameObject highlightBG;
    [SerializeField]
    private Color highlightColor;
    [SerializeField]
    public bool ShowWhenEmpty;
    [SerializeField]
    public Image Icon;
    private ToggleExtended toggle;
    public Action<PartCategories> OnCategoryButtonClicked;
    private bool isSettingFromCode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSelected(bool toggleState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleChangedByUI(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyCategoryButton() => throw null;
  }
}
