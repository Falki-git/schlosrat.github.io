﻿// Decompiled with JetBrains decompiler
// Type: LoadingScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class LoadingScreen
{
  public bool Enabled;
  public bool FadeIn;
  public bool FadeOut;
  public CurtainContext Context;
  public List<string> ScreenKeys;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LoadingScreen() => throw null;
}
