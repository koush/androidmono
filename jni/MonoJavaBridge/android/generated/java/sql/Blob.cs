namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Blob_))]
	public interface Blob  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class Blob_ : java.lang.Object, Blob
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Blob_()
		{
			InitJNI();
		}
		internal Blob_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _length18374;
		 long java.sql.Blob.length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Blob_._length18374);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._length18374);
		}
		internal static global::MonoJavaBridge.MethodId _getBytes18375;
		 byte[] java.sql.Blob.getBytes(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Blob_._getBytes18375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._getBytes18375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _position18376;
		 long java.sql.Blob.position(byte[] arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Blob_._position18376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._position18376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _position18377;
		 long java.sql.Blob.position(java.sql.Blob arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Blob_._position18377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._position18377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _truncate18378;
		 void java.sql.Blob.truncate(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Blob_._truncate18378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._truncate18378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _free18379;
		 void java.sql.Blob.free() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Blob_._free18379);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._free18379);
		}
		internal static global::MonoJavaBridge.MethodId _getBinaryStream18380;
		 global::java.io.InputStream java.sql.Blob.getBinaryStream(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Blob_._getBinaryStream18380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._getBinaryStream18380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getBinaryStream18381;
		 global::java.io.InputStream java.sql.Blob.getBinaryStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Blob_._getBinaryStream18381)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._getBinaryStream18381)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _setBytes18382;
		 int java.sql.Blob.setBytes(long arg0, byte[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Blob_._setBytes18382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._setBytes18382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setBytes18383;
		 int java.sql.Blob.setBytes(long arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Blob_._setBytes18383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._setBytes18383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream18384;
		 global::java.io.OutputStream java.sql.Blob.setBinaryStream(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Blob_._setBinaryStream18384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Blob_.staticClass, global::java.sql.Blob_._setBinaryStream18384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Blob_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Blob"));
			global::java.sql.Blob_._length18374 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "length", "()J");
			global::java.sql.Blob_._getBytes18375 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "getBytes", "(JI)[B");
			global::java.sql.Blob_._position18376 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "position", "([BJ)J");
			global::java.sql.Blob_._position18377 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "position", "(Ljava/sql/Blob;J)J");
			global::java.sql.Blob_._truncate18378 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "truncate", "(J)V");
			global::java.sql.Blob_._free18379 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "free", "()V");
			global::java.sql.Blob_._getBinaryStream18380 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "getBinaryStream", "(JJ)Ljava/io/InputStream;");
			global::java.sql.Blob_._getBinaryStream18381 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "getBinaryStream", "()Ljava/io/InputStream;");
			global::java.sql.Blob_._setBytes18382 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "setBytes", "(J[BII)I");
			global::java.sql.Blob_._setBytes18383 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "setBytes", "(J[B)I");
			global::java.sql.Blob_._setBinaryStream18384 = @__env.GetMethodIDNoThrow(global::java.sql.Blob_.staticClass, "setBinaryStream", "(J)Ljava/io/OutputStream;");
		}
	}
}
