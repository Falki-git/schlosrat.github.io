﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.SlideData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  [Serializable]
  public class SlideData
  {
    public int Index;
    public string ScriptableObjectKey;
    public string HeaderText;
    public string BodyText;
    [NonSerialized]
    public bool _IsBeingSelected;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SlideData DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SlideData() => throw null;
  }
}
