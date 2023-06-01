﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.ESCMenuDynamicElements
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [DisableCustomEditorBase]
  [Serializable]
  public class ESCMenuDynamicElements : KerbalMonoBehaviour
  {
    public const string PLAYER_INFORMATION_LOCALIZATION_KEY = "Menu/Escape/";
    [SerializeField]
    private Image iconObject;
    [SerializeField]
    private TextMeshProUGUI nameObject;
    public string NameText;
    public Sprite Icon;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeNameIcon() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ESCMenuDynamicElements() => throw null;
  }
}
