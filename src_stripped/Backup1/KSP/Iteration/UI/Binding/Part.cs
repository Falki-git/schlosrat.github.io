﻿// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.Binding.Part
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;

namespace KSP.Iteration.UI.Binding
{
  public class Part : ApiDataContext
  {
    [DataProperty("name")]
    public PropertyReadonly<string> name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [DataProperty("isOn")]
    public Property<bool> isOn
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Part(string name) => throw null;

    [DataAction("toggleIsOn")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleIsOn() => throw null;
  }
}
