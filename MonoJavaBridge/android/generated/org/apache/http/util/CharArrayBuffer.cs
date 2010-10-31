namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CharArrayBuffer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CharArrayBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.util.CharArrayBuffer._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void append(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Ljava/lang/String;)V", ref global::org.apache.http.util.CharArrayBuffer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void append(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Lorg/apache/http/util/CharArrayBuffer;II)V", ref global::org.apache.http.util.CharArrayBuffer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void append(org.apache.http.util.CharArrayBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Lorg/apache/http/util/CharArrayBuffer;)V", ref global::org.apache.http.util.CharArrayBuffer._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void append(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(C)V", ref global::org.apache.http.util.CharArrayBuffer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void append(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "([BII)V", ref global::org.apache.http.util.CharArrayBuffer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void append(org.apache.http.util.ByteArrayBuffer arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Lorg/apache/http/util/ByteArrayBuffer;II)V", ref global::org.apache.http.util.CharArrayBuffer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public void append(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Ljava/lang/Object;)V", ref global::org.apache.http.util.CharArrayBuffer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void append(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "([CII)V", ref global::org.apache.http.util.CharArrayBuffer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public int indexOf(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "indexOf", "(I)I", ref global::org.apache.http.util.CharArrayBuffer._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public int indexOf(int arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "indexOf", "(III)I", ref global::org.apache.http.util.CharArrayBuffer._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "clear", "()V", ref global::org.apache.http.util.CharArrayBuffer._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "length", "()I", ref global::org.apache.http.util.CharArrayBuffer._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "isEmpty", "()Z", ref global::org.apache.http.util.CharArrayBuffer._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public char charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "charAt", "(I)C", ref global::org.apache.http.util.CharArrayBuffer._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public global::java.lang.String substring(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "substring", "(II)Ljava/lang/String;", ref global::org.apache.http.util.CharArrayBuffer._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public char[] toCharArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "toCharArray", "()[C", ref global::org.apache.http.util.CharArrayBuffer._m16) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public void ensureCapacity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "ensureCapacity", "(I)V", ref global::org.apache.http.util.CharArrayBuffer._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public int capacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "capacity", "()I", ref global::org.apache.http.util.CharArrayBuffer._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public void setLength(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "setLength", "(I)V", ref global::org.apache.http.util.CharArrayBuffer._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public char[] buffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "buffer", "()[C", ref global::org.apache.http.util.CharArrayBuffer._m20) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public bool isFull()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "isFull", "()Z", ref global::org.apache.http.util.CharArrayBuffer._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public global::java.lang.String substringTrimmed(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.util.CharArrayBuffer.staticClass, "substringTrimmed", "(II)Ljava/lang/String;", ref global::org.apache.http.util.CharArrayBuffer._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public CharArrayBuffer(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.CharArrayBuffer._m23.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.CharArrayBuffer._m23 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CharArrayBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.CharArrayBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/CharArrayBuffer"));
		}
	}
}
