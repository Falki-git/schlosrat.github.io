﻿// Decompiled with JetBrains decompiler
// Type: UIValue_ReadBool_Text
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

[RequireComponent(typeof (TextMeshProUGUI))]
public class UIValue_ReadBool_Text : UIValueBinder<bool>
{
  [SerializeField]
  private TextMeshProUGUI _target;
  [SerializeField]
  private string _onText;
  [SerializeField]
  private string _offText;
  [SerializeField]
  private bool _treatTextAsLocKey;
  private ToStringDelegate _toStringDelegateFromMetadata;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void RedrawValue(bool instant = true) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateMetadataFromContext() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UIValue_ReadBool_Text() => throw null;
}
