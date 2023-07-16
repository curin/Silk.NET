// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDWriteFontSet"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class IDWriteFontSetTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDWriteFontSet"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWriteFontSet).GUID, Is.EqualTo(IID_IDWriteFontSet));
    }

    /// <summary>Validates that the <see cref = "IDWriteFontSet"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWriteFontSet>(), Is.EqualTo(sizeof(IDWriteFontSet)));
    }

    /// <summary>Validates that the <see cref = "IDWriteFontSet"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWriteFontSet).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDWriteFontSet"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWriteFontSet), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWriteFontSet), Is.EqualTo(4));
        }
    }
}