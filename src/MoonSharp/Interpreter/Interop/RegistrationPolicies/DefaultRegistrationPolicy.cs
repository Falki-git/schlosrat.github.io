﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.RegistrationPolicies.DefaultRegistrationPolicy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.RegistrationPolicies
{
  public class DefaultRegistrationPolicy : IRegistrationPolicy
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IUserDataDescriptor HandleRegistration(
      IUserDataDescriptor newDescriptor,
      IUserDataDescriptor oldDescriptor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool AllowTypeAutoRegistration(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultRegistrationPolicy() => throw null;
  }
}
