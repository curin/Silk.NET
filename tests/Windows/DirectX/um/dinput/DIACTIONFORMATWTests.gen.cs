// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DIACTIONFORMATW"/> struct.</summary>
public static unsafe partial class DIACTIONFORMATWTests
{
    /// <summary>Validates that the <see cref = "DIACTIONFORMATW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DIACTIONFORMATW>(), Is.EqualTo(sizeof(DIACTIONFORMATW)));
    }

    /// <summary>Validates that the <see cref = "DIACTIONFORMATW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DIACTIONFORMATW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DIACTIONFORMATW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DIACTIONFORMATW), Is.EqualTo(600));
        }
        else
        {
            Assert.That(sizeof(DIACTIONFORMATW), Is.EqualTo(588));
        }
    }
}