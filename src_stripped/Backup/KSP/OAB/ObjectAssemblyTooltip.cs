﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyTooltip : MonoBehaviour
  {
    [SerializeField]
    private Vector2 tooltipOffset;
    [SerializeField]
    private RectTransform cursorBox;
    [SerializeField]
    private float _typeInTime;
    [SerializeField]
    private float _blinkInterval;
    private float _baseWidth;
    private RectTransform _rectTransform;
    private ObjectAssemblyUIEvents eventsUI;
    private ObjectAssemblyBuilderEvents eventsBuilder;
    private TextMeshProUGUI textMesh;
    private string destText;

    protected string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEvents(
      ObjectAssemblyBuilderEvents builderEvents,
      ObjectAssemblyUIEvents eventsToUse)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnShowTooltip(string textToDisplay, RectTransform baseRect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHideTooltip() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator Displaying() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyTooltip() => throw null;
  }
}
