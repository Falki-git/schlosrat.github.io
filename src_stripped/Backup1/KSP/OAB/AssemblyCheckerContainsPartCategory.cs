﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.AssemblyCheckerContainsPartCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  [Serializable]
  public class AssemblyCheckerContainsPartCategory : EngineeringReportFlawListCheckerBase
  {
    public PartCategories RequirePartCategory;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override EngineeringReportFlawListCheckResult Check(OABSessionInformation sessionInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyCheckerContainsPartCategory() => throw null;
  }
}
