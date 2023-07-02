﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.UIValue_InfoGridElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI
{
  public class UIValue_InfoGridElement : UIValueBinder
  {
    [Header("Pass Units directly or loc path")]
    [Tooltip("This can totally be empty.")]
    public string units;
    [Header("Links")]
    public TextMeshProUGUI valueText;
    [SerializeField]
    [Header("Decimal rounding options")]
    private bool _roundValue;
    [SerializeField]
    private int _decimalPlaces;
    [SerializeField]
    private bool _forceDecimalPlaces;
    [SerializeField]
    private bool _roundAllDecimalPlacesOnLargeRoundedNumbers;
    [SerializeField]
    private int _roundAllDecimalPlacesForNumbersOver;
    [SerializeField]
    private bool _useScientificNotationOnLargeRoundedNumbers;
    [SerializeField]
    private int _useScientificNotationForNumbersOver;
    private string _roundedFormatString;
    private string _scientificNotationFormatString;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetTargetActive(bool isBound) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_InfoGridElement() => throw null;
  }
}
