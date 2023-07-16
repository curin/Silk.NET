// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMAGE_BDD_DYNAMIC_RELOCATION"/> struct.</summary>
public static unsafe partial class IMAGE_BDD_DYNAMIC_RELOCATIONTests
{
    /// <summary>Validates that the <see cref = "IMAGE_BDD_DYNAMIC_RELOCATION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMAGE_BDD_DYNAMIC_RELOCATION>(), Is.EqualTo(sizeof(IMAGE_BDD_DYNAMIC_RELOCATION)));
    }

    /// <summary>Validates that the <see cref = "IMAGE_BDD_DYNAMIC_RELOCATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGE_BDD_DYNAMIC_RELOCATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMAGE_BDD_DYNAMIC_RELOCATION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGE_BDD_DYNAMIC_RELOCATION), Is.EqualTo(8));
    }
}