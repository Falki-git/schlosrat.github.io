﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValue_Function_Menu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

namespace KSP.UI.Binding.Core
{
  public class UIValue_Function_Menu : MonoBehaviour
  {
    public List<UIValue_Function_Menu_Member> boolBindings;
    public Transform m_Transform;
    public float m_Radius;
    private float m_Theta;
    private int ListCount;
    private float[] TogglePositionList;
    private UIValue_Function_Menu_Member m_CorrectToggle;
    private bool activeSelected;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawSASWheel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SelectCorrectToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActiveChoseFunction(InputAction.CallbackContext obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DisableFunctionMenuWheel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_Function_Menu() => throw null;
  }
}
