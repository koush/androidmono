namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Blob_))]
	public partial interface Blob  : global::MonoJavaBridge.IJavaObject 
	{
		long length();
		byte[] getBytes(long arg0, int arg1);
		long position(byte[] arg0, long arg1);
		long position(java.sql.Blob arg0, long arg1);
		void truncate(long arg0);
		void free();
		global::java.io.InputStream getBinaryStream(long arg0, long arg1);
		global::java.io.InputStream getBinaryStream();
		int setBytes(long arg0, byte[] arg1, int arg2, int arg3);
		int setBytes(long arg0, byte[] arg1);
		global::java.io.OutputStream setBinaryStream(long arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.Blob))]
	internal sealed partial class Blob_ : java.lang.Object, Blob
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Blob_()
		{
			InitJNI();
		}
		internal Blob_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _length24101;
		 long java.sql.Blob.length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Blob_._length24101);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._length24101);
		}
		internal static global::MonoJavaBridge.MethodId _getBytes24102;
		 byte[] java.sql.Blob.getBytes(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Blob_._getBytes24102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._getBytes24102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _position24103;
		 long java.sql.Blob.position(byte[] arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Blob_._position24103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._position24103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _position24104;
		 long java.sql.Blob.position(java.sql.Blob arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Blob_._position24104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._position24104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _truncate24105;
		 void java.sql.Blob.truncate(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Blob_._truncate24105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._truncate24105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _free24106;
		 void java.sql.Blob.free() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Blob_._free24106);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._free24106);
		}
		internal static global::MonoJavaBridge.MethodId _getBinaryStream24107;
		 global::java.io.InputStream java.sql.Blob.getBinaryStream(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Blob_._getBinaryStream24107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._getBinaryStream24107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getBinaryStream24108;
		 global::java.io.InputStream java.sql.Blob.getBinaryStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Blob_._getBinaryStream24108)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._getBinaryStream24108)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _setBytes24109;
		 int java.sql.Blob.setBytes(long arg0, byte[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Blob_._setBytes24109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._setBytes24109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setBytes24110;
		 int java.sql.Blob.setBytes(long arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Blob_._setBytes24110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._setBytes24110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24111;
		 global::java.io.OutputStream java.sql.Blob.setBinaryStream(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Blob_._setBinaryStream24111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._setBinaryStream24111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Blob_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Blob"));
			global::java.sql.Blob_._length24101 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "length", "()J");
			global::java.sql.Blob_._getBytes24102 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "getBytes", "(JI)[B");
			global::java.sql.Blob_._position24103 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "position", "([BJ)J");
			global::java.sql.Blob_._position24104 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "position", "(Ljava/sql/Blob;J)J");
			global::java.sql.Blob_._truncate24105 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "truncate", "(J)V");
			global::java.sql.Blob_._free24106 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "free", "()V");
			global::java.sql.Blob_._getBinaryStream24107 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "getBinaryStream", "(JJ)Ljava/io/InputStream;");
			global::java.sql.Blob_._getBinaryStream24108 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "getBinaryStream", "()Ljava/io/InputStream;");
			global::java.sql.Blob_._setBytes24109 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "setBytes", "(J[BII)I");
			global::java.sql.Blob_._setBytes24110 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "setBytes", "(J[B)I");
			global::java.sql.Blob_._setBinaryStream24111 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "setBinaryStream", "(J)Ljava/io/OutputStream;");
		}
	}
}
