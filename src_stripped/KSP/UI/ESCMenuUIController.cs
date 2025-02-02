﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.ESCMenuUIController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [DisableCustomEditorBase]
  [Serializable]
  public class ESCMenuUIController : KerbalMonoBehaviour
  {
    public GameObject PlayercardElement;
    public GameObject ActionElement;
    private ESCMenuActionElementsController _escMenuActionElementsController;
    private ESCMenuActionElements[] _actionElements;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateRevertAvailability() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameLanguageChanged(MessageCenterMessage newLanguageMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetIDsForAvaiableActionElements(ESCMenuActionElements[] actionElements) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ESCMenuUIController() => throw null;
  }
}
