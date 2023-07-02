﻿// Decompiled with JetBrains decompiler
// Type: KSP.Input.ToggleableInputAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;

namespace KSP.Input
{
  public abstract class ToggleableInputAction
  {
    protected bool _enabled;
    protected InputAction _inputAction;

    public InputAction InputAction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ToggleableInputAction(InputAction inputAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetState(bool enabled, bool forced = false) => throw null;
  }
}
