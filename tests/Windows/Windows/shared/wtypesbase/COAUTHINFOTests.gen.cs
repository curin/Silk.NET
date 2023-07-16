// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "COAUTHINFO"/> struct.</summary>
public static unsafe partial class COAUTHINFOTests
{
    /// <summary>Validates that the <see cref = "COAUTHINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<COAUTHINFO>(), Is.EqualTo(sizeof(COAUTHINFO)));
    }

    /// <summary>Validates that the <see cref = "COAUTHINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(COAUTHINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "COAUTHINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(COAUTHINFO), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(COAUTHINFO), Is.EqualTo(28));
        }
    }
}