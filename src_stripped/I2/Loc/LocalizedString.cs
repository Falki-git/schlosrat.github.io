﻿// Decompiled with JetBrains decompiler
// Type: I2.Loc.LocalizedString
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace I2.Loc
{
  [Serializable]
  public struct LocalizedString
  {
    public string mTerm;
    public bool mRTL_IgnoreArabicFix;
    public int mRTL_MaxLineLength;
    public bool mRTL_ConvertNumbers;
    public bool m_DontLocalizeParameters;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator string(LocalizedString s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator LocalizedString(string term) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalizedString(LocalizedString str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;
  }
}
