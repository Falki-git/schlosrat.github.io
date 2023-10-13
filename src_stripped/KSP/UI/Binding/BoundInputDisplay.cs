﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.BoundInputDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Input;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class BoundInputDisplay : KerbalMonoBehaviour
  {
    private const string KEYBOARD_DISPLAY_GROUP = "Keyboard";
    private const string GAMEPAD_DISPLAY_GROUP = "Gamepad";
    [SerializeField]
    private string _definitionID;
    [SerializeField]
    private string _actionID;
    [SerializeField]
    private bool _useIcon;
    [SerializeField]
    private bool _inlineText;
    [SerializeField]
    private BindingDisplayData[] _displayData;
    [SerializeField]
    private TextMeshProUGUI _text;
    [SerializeField]
    private Image _image;
    [SerializeField]
    [Tooltip("Use the raw string obtained from input rather than the formatted display data")]
    private bool _useControlString;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDisplay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BindingDisplayData GetDisplayFromControlString(string controlString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetActionData(
      string definitionID,
      string actionID,
      out ToggleableInputAction action)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetCurrentDisplayGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoundInputDisplay() => throw null;
  }
}
