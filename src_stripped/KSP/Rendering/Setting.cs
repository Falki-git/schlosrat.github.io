﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Setting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Rendering
{
  [Serializable]
  public abstract class Setting
  {
    public string Name;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Setting() => throw null;
  }
}
