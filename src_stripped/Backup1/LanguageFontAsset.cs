﻿// Decompiled with JetBrains decompiler
// Type: LanguageFontAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;

[Serializable]
public struct LanguageFontAsset
{
  public string LanguageName;
  public TMP_FontAsset FontAsset;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool TryGetFontByName(
    string languageName,
    List<LanguageFontAsset> languageFonts,
    out TMP_FontAsset fontAsset)
  {
    throw null;
  }
}
