﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.FlightReportResearchItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Flight
{
  public class FlightReportResearchItem : KerbalMonoBehaviour
  {
    [SerializeField]
    private Image _researchIcon;
    [SerializeField]
    private TextMeshProUGUI _researchTitle;
    [SerializeField]
    private TextMeshProUGUI _researchValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(Sprite icon, string title, int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightReportResearchItem() => throw null;
  }
}
