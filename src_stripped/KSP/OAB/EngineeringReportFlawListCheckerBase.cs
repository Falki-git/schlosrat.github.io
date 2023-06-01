﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.EngineeringReportFlawListCheckerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  [Serializable]
  public abstract class EngineeringReportFlawListCheckerBase
  {
    public string TitleLocalizationTerm;
    public EngineerReportSeverity Severity;
    public PartCategories FlawCategory;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract EngineeringReportFlawListCheckResult Check(OABSessionInformation sessionInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected EngineeringReportFlawListCheckerBase() => throw null;
  }
}
