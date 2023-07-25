﻿// Decompiled with JetBrains decompiler
// Type: KSP.Input.InputManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;

namespace KSP.Input
{
  public class InputManager : KerbalMonoBehaviour, IDisposable
  {
    private Dictionary<string, InputDefinition> _inputDefinitions;
    private InputLockDefinition _currentInputLock;
    private Device _currentDevice;

    public Device CurrentDevice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveGamepadCallback(InputDevice device, InputDeviceChange change) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddDefinition<T>(T definition) where T : InputDefinition => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetInputDefinition<T>(out T definition) where T : InputDefinition => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetInputDefinition(string definitionID, out InputDefinition definition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInputLock(InputLockDefinition definition, bool forced = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputManager() => throw null;
  }
}
