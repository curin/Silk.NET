// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mssip.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SIP_DISPATCH_INFO"/> struct.</summary>
public static unsafe partial class SIP_DISPATCH_INFOTests
{
    /// <summary>Validates that the <see cref = "SIP_DISPATCH_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SIP_DISPATCH_INFO>(), Is.EqualTo(sizeof(SIP_DISPATCH_INFO)));
    }

    /// <summary>Validates that the <see cref = "SIP_DISPATCH_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SIP_DISPATCH_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SIP_DISPATCH_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SIP_DISPATCH_INFO), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(SIP_DISPATCH_INFO), Is.EqualTo(28));
        }
    }
}