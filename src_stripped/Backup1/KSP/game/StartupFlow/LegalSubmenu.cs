﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.StartupFlow.LegalSubmenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.Game.StartupFlow
{
  public class LegalSubmenu : KerbalMonoBehaviour
  {
    public string Name;
    public TMP_Text LegalText;
    [SerializeField]
    private GameObject _link;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActive(bool isActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegalSubmenu() => throw null;
  }
}
