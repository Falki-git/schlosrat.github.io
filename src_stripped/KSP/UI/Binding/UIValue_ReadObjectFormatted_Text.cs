﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadObjectFormatted_Text
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_ReadObjectFormatted_Text : UIValueBinder
  {
    [SerializeField]
    private TMP_Text text;
    private ToStringDelegate _toStringDelegateFromMetadata;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual string GetValueAsString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void UpdateMetadataFromContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadObjectFormatted_Text() => throw null;
  }
}
