using System;
using System.Collections.Generic;

namespace DSharpPlus.Entities.Internal.VoiceGateway;

public sealed record InternalVoicePacket
{
    public byte VersionAndFlags { get; init; } = 0x80;
    public byte PayloadType { get; init; } = 0x78;
    public ushort Sequence { get; init; }
    public uint Timestamp { get; init; }
    public uint SSRC { get; init; }
    public IReadOnlyList<byte> EncryptedAudio { get; init; } = Array.Empty<byte>();
}