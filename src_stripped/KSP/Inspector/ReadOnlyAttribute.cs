﻿// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.ReadOnlyAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Inspector
{
  [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
  public class ReadOnlyAttribute : PropertyAttribute
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReadOnlyAttribute() => throw null;
  }
}
