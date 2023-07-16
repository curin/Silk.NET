// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CHANGER_READ_ELEMENT_STATUS"/> struct.</summary>
public static unsafe partial class CHANGER_READ_ELEMENT_STATUSTests
{
    /// <summary>Validates that the <see cref = "CHANGER_READ_ELEMENT_STATUS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CHANGER_READ_ELEMENT_STATUS>(), Is.EqualTo(sizeof(CHANGER_READ_ELEMENT_STATUS)));
    }

    /// <summary>Validates that the <see cref = "CHANGER_READ_ELEMENT_STATUS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CHANGER_READ_ELEMENT_STATUS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CHANGER_READ_ELEMENT_STATUS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CHANGER_READ_ELEMENT_STATUS), Is.EqualTo(16));
    }
}