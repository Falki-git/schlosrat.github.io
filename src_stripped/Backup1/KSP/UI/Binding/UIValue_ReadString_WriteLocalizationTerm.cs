﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadString_WriteLocalizationTerm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using I2.Loc;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;

namespace KSP.UI.Binding
{
  public class UIValue_ReadString_WriteLocalizationTerm : UIValueBinder<string>
  {
    public Localize LocalizeTarget;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLocalizationTerm(bool isBound) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadString_WriteLocalizationTerm() => throw null;
  }
}
