//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\appinfo.dll
// Interface ID: 58e604e8-9adb-4d2e-a464-3b0683fb1480
// Interface Version: 1.0



namespace rpc_58e604e8_9adb_4d2e_a464_3b0683fb1480_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("58e604e8-9adb-4d2e-a464-3b0683fb1480", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        // async
        public int RAiGetTokenForAxIS(NtApiDotNet.Ndr.Marshal.NdrUInt3264 p0, int p1, int p2, string p3, string p4, string p5, int p6, out NtApiDotNet.Ndr.Marshal.NdrUInt3264 p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteUInt3264(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"));
            m.WriteInt32(p6);
            _Unmarshal_Helper u = SendReceive(0, m);
            p7 = u.ReadUInt3264();
            return u.ReadInt32();
        }
    }
    #endregion
}

