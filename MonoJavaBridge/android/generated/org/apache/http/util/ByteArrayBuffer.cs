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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "([BII)V", ref global::org.apache.http.util.ByteArrayBuffer._append33966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append33967;
		public void append(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "(I)V", ref global::org.apache.http.util.ByteArrayBuffer._append33967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append33968;
		public void append(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "([CII)V", ref global::org.apache.http.util.ByteArrayBuffer._append33968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append33969;
		public void append(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "(Lorg/apache/http/util/CharArrayBuffer;II)V", ref global::org.apache.http.util.ByteArrayBuffer._append33969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clear33970;
		public void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "clear", "()V", ref global::org.apache.http.util.ByteArrayBuffer._clear33970);
		}
		internal static global::MonoJavaBridge.MethodId _length33971;
		public int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "length", "()I", ref global::org.apache.http.util.ByteArrayBuffer._length33971);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty33972;
		public bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "isEmpty", "()Z", ref global::org.apache.http.util.ByteArrayBuffer._isEmpty33972);
		}
		internal static global::MonoJavaBridge.MethodId _capacity33973;
		public int capacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "capacity", "()I", ref global::org.apache.http.util.ByteArrayBuffer._capacity33973);
		}
		internal static global::MonoJavaBridge.MethodId _setLength33974;
		public void setLength(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "setLength", "(I)V", ref global::org.apache.http.util.ByteArrayBuffer._setLength33974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray33975;
		public byte[] toByteArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "toByteArray", "()[B", ref global::org.apache.http.util.ByteArrayBuffer._toByteArray33975) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _buffer33976;
		public byte[] buffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "buffer", "()[B", ref global::org.apache.http.util.ByteArrayBuffer._buffer33976) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _isFull33977;
		public bool isFull()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "isFull", "()Z", ref global::org.apache.http.util.ByteArrayBuffer._isFull33977);
		}
		internal static global::MonoJavaBridge.MethodId _byteAt33978;
		public int byteAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "byteAt", "(I)I", ref global::org.apache.http.util.ByteArrayBuffer._byteAt33978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
