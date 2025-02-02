﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.InputFieldIconController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;

namespace UnityEngine.UI
{
  [RequireComponent(typeof (InputFieldExtended))]
  public class InputFieldIconController : KerbalMonoBehaviour
  {
    [SerializeField]
    private CanvasGroup _editIconCanvasGroup;
    [Space]
    [SerializeField]
    private CanvasGroup _clearButtonCanvasGroup;
    [Space]
    [SerializeField]
    private ButtonExtended _clearButton;
    [Space]
    [SerializeField]
    private CanvasGroup _characterNumberCanvasGroup;
    [SerializeField]
    private TextMeshProUGUI _characterNumberText;
    [Header("Custom options")]
    [SerializeField]
    private bool _useCustomClearButtonAction;
    [SerializeField]
    private bool _showEditIconOnNormalState;
    private InputFieldExtended _inputField;
    private SelectionState _mostRecentState;
    private bool _isCursorOnButton;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleStateChange(SelectionState state, bool val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ValueChangedEvent(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeselect(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearInteracted() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleButtonChange(SelectionState state, bool val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetElementImageStates(bool buttonState, bool iconState, bool characterNbr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputFieldIconController() => throw null;
  }
}
