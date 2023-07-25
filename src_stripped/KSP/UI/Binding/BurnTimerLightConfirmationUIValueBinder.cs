﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.BurnTimerLightConfirmationUIValueBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class BurnTimerLightConfirmationUIValueBinder : UIValueEnumBinder
  {
    private const string CORRECT_TIME_ENUM_STRING = "CorrectTime";
    private const string INCORRECT_TIME_ENUM_STRING = "IncorrectTime";
    [SerializeField]
    private bool _isStartBurn;
    private bool _isInitialized;
    private Image[] _lights;
    private Color _offColor;
    private Color _greenColor;
    private Color _yellowColor;
    private Color _redColor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      Image[] lights,
      Color offColor,
      Color greenColor,
      Color yellowColor,
      Color redColor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleFinalLightTreeFlash(bool playerBurnStartedOnTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateIsBeforeManeuver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BurnTimerLightConfirmationUIValueBinder() => throw null;
  }
}
