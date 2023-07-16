// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMAGE_ARCHITECTURE_ENTRY"/> struct.</summary>
public static unsafe partial class IMAGE_ARCHITECTURE_ENTRYTests
{
    /// <summary>Validates that the <see cref = "IMAGE_ARCHITECTURE_ENTRY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMAGE_ARCHITECTURE_ENTRY>(), Is.EqualTo(sizeof(IMAGE_ARCHITECTURE_ENTRY)));
    }

    /// <summary>Validates that the <see cref = "IMAGE_ARCHITECTURE_ENTRY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGE_ARCHITECTURE_ENTRY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMAGE_ARCHITECTURE_ENTRY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGE_ARCHITECTURE_ENTRY), Is.EqualTo(8));
    }
}