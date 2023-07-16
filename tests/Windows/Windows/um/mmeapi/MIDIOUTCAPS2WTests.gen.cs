// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MIDIOUTCAPS2W"/> struct.</summary>
public static unsafe partial class MIDIOUTCAPS2WTests
{
    /// <summary>Validates that the <see cref = "MIDIOUTCAPS2W"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIDIOUTCAPS2W>(), Is.EqualTo(sizeof(MIDIOUTCAPS2W)));
    }

    /// <summary>Validates that the <see cref = "MIDIOUTCAPS2W"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIDIOUTCAPS2W).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MIDIOUTCAPS2W"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MIDIOUTCAPS2W), Is.EqualTo(132));
    }
}