// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SCHANNEL_CRED"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class SCHANNEL_CREDTests
{
    /// <summary>Validates that the <see cref = "SCHANNEL_CRED"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SCHANNEL_CRED>(), Is.EqualTo(sizeof(SCHANNEL_CRED)));
    }

    /// <summary>Validates that the <see cref = "SCHANNEL_CRED"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SCHANNEL_CRED).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SCHANNEL_CRED"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SCHANNEL_CRED), Is.EqualTo(80));
        }
        else
        {
            Assert.That(sizeof(SCHANNEL_CRED), Is.EqualTo(56));
        }
    }
}