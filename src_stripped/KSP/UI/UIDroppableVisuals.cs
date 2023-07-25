﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.UIDroppableVisuals
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class UIDroppableVisuals : MonoBehaviour
  {
    [SerializeField]
    private bool _isPendingDrop;
    [SerializeField]
    private UIDroppableVisuals.PendingDropVisualStyle _styleWhenPendingDrop;
    [SerializeField]
    private Color _highlightColor;
    private Color _startingColor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    public bool IsPendingDrop
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIDroppableVisuals() => throw null;

    public enum PendingDropVisualStyle
    {
      None,
      Highlight,
    }
  }
}
