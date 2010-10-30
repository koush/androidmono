namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ByteArrayBuffer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ByteArrayBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _append33966;
		public void append(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._append33966.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._append33966 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "([BII)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._append33966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append33967;
		public void append(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._append33967.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._append33967 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "(I)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._append33967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append33968;
		public void append(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._append33968.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._append33968 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "([CII)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._append33968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append33969;
		public void append(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._append33969.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._append33969 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "(Lorg/apache/http/util/CharArrayBuffer;II)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._append33969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clear33970;
		public void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._clear33970.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._clear33970 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "clear", "()V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._clear33970);
		}
		internal static global::MonoJavaBridge.MethodId _length33971;
		public int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._length33971.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._length33971 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "length", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._length33971);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty33972;
		public bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._isEmpty33972.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._isEmpty33972 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "isEmpty", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._isEmpty33972);
		}
		internal static global::MonoJavaBridge.MethodId _capacity33973;
		public int capacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._capacity33973.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._capacity33973 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "capacity", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._capacity33973);
		}
		internal static global::MonoJavaBridge.MethodId _setLength33974;
		public void setLength(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._setLength33974.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._setLength33974 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "setLength", "(I)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._setLength33974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray33975;
		public byte[] toByteArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._toByteArray33975.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._toByteArray33975 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "toByteArray", "()[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._toByteArray33975)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _buffer33976;
		public byte[] buffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._buffer33976.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._buffer33976 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "buffer", "()[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._buffer33976)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _isFull33977;
		public bool isFull()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._isFull33977.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._isFull33977 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "isFull", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._isFull33977);
		}
		internal static global::MonoJavaBridge.MethodId _byteAt33978;
		public int byteAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._byteAt33978.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._byteAt33978 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "byteAt", "(I)I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._byteAt33978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayBuffer33979;
		public ByteArrayBuffer(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._ByteArrayBuffer33979.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._ByteArrayBuffer33979 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._ByteArrayBuffer33979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ByteArrayBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.ByteArrayBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/ByteArrayBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
