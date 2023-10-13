﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.TestToggleExtendedAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
  [RequireComponent(typeof (ToggleExtended))]
  public class TestToggleExtendedAudio : MonoBehaviour
  {
    [Header("If preset is set, will use its identifier value")]
    public TestUIAudioIdentifierPreset identifierPreset;
    [Header("If no preset is set, will use this identifier:")]
    public string identifier;
    private ToggleExtended toggle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleStateTransitionWithOverrides(SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandleUITransitionForAudio(
      string identifier,
      SelectionState state,
      bool isOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestToggleExtendedAudio() => throw null;
  }
}
