namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ByteArrayBuffer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ByteArrayBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public void append(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "([BII)V", ref global::org.apache.http.util.ByteArrayBuffer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void append(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "(I)V", ref global::org.apache.http.util.ByteArrayBuffer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void append(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "([CII)V", ref global::org.apache.http.util.ByteArrayBuffer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void append(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "(Lorg/apache/http/util/CharArrayBuffer;II)V", ref global::org.apache.http.util.ByteArrayBuffer._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "clear", "()V", ref global::org.apache.http.util.ByteArrayBuffer._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "length", "()I", ref global::org.apache.http.util.ByteArrayBuffer._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "isEmpty", "()Z", ref global::org.apache.http.util.ByteArrayBuffer._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public int capacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "capacity", "()I", ref global::org.apache.http.util.ByteArrayBuffer._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void setLength(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "setLength", "(I)V", ref global::org.apache.http.util.ByteArrayBuffer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public byte[] toByteArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "toByteArray", "()[B", ref global::org.apache.http.util.ByteArrayBuffer._m9) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public byte[] buffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "buffer", "()[B", ref global::org.apache.http.util.ByteArrayBuffer._m10) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public bool isFull()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "isFull", "()Z", ref global::org.apache.http.util.ByteArrayBuffer._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public int byteAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.util.ByteArrayBuffer.staticClass, "byteAt", "(I)I", ref global::org.apache.http.util.ByteArrayBuffer._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public ByteArrayBuffer(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ByteArrayBuffer._m13.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ByteArrayBuffer._m13 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ByteArrayBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.ByteArrayBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/ByteArrayBuffer"));
		}
	}
}
