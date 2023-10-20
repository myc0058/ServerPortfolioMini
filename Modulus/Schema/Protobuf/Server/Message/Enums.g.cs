// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Enums.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Schema.Protobuf.Message.Enums {

  /// <summary>Holder for reflection information generated from Enums.proto</summary>
  public static partial class EnumsReflection {

    #region Descriptor
    /// <summary>File descriptor for Enums.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnumsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtFbnVtcy5wcm90bxIdU2NoZW1hLlByb3RvYnVmLk1lc3NhZ2UuRW51bXMq",
            "dgoMUmVzcG9uc2VDb2RlEhUKEVJlc3BvbnNlQ29kZV9OT05FEAASGAoUUmVz",
            "cG9uc2VDb2RlX1NVQ0NFU1MQARIVChFSZXNwb25zZUNvZGVfRkFJTBACEh4K",
            "GlJlc3BvbnNlQ29kZV9ZT1VfTkVFRF9ST09NEAMqeQoOQ2xpZW50UGxhdGZv",
            "cm0SFwoTQ0xJRU5UUExBVEZPUk1fTk9ORRAAEhkKFUNMSUVOVFBMQVRGT1JN",
            "X0VESVRPUhABEhkKFUNMSUVOVFBMQVRGT1JNX0dPT0dMRRACEhgKFENMSUVO",
            "VFBMQVRGT1JNX0FQUExFEANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Schema.Protobuf.Message.Enums.ResponseCode), typeof(global::Schema.Protobuf.Message.Enums.ClientPlatform), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ResponseCode {
    [pbr::OriginalName("ResponseCode_NONE")] None = 0,
    [pbr::OriginalName("ResponseCode_SUCCESS")] Success = 1,
    [pbr::OriginalName("ResponseCode_FAIL")] Fail = 2,
    [pbr::OriginalName("ResponseCode_YOU_NEED_ROOM")] YouNeedRoom = 3,
  }

  public enum ClientPlatform {
    [pbr::OriginalName("CLIENTPLATFORM_NONE")] None = 0,
    [pbr::OriginalName("CLIENTPLATFORM_EDITOR")] Editor = 1,
    [pbr::OriginalName("CLIENTPLATFORM_GOOGLE")] Google = 2,
    [pbr::OriginalName("CLIENTPLATFORM_APPLE")] Apple = 3,
  }

  #endregion

}

#endregion Designer generated code
