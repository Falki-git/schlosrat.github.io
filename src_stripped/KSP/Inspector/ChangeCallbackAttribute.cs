﻿// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.ChangeCallbackAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Inspector
{
  public class ChangeCallbackAttribute : PropertyAttribute
  {
    public string callbackPath;
    public bool runInEditor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChangeCallbackAttribute(string callbackFunc, bool runInEditMode = false) => throw null;
  }
}
