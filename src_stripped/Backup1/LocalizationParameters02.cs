﻿// Decompiled with JetBrains decompiler
// Type: LocalizationParameters02
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LocalizationParameters02 : MonoBehaviour
{
  public Property<string> NumDogsInternal;
  [SerializeField]
  private string numDogs;
  [SerializeField]
  private UIValue_ReadLocalizedString_Text UIBinder;
  private string LastNumDogs;
  public ContextBindRoot target;
  private DataContext paramData;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LocalizationParameters02() => throw null;
}
