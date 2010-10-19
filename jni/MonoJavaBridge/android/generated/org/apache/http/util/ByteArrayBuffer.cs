namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ByteArrayBuffer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ByteArrayBuffer()
		{
			InitJNI();
		}
		internal ByteArrayBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _append27163;
		public void append(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer._append27163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._append27163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append27164;
		public void append(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer._append27164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._append27164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append27165;
		public void append(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer._append27165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._append27165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append27166;
		public void append(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer._append27166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._append27166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clear27167;
		public void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer._clear27167);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._clear27167);
		}
		internal static global::MonoJavaBridge.MethodId _length27168;
		public int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer._length27168);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._length27168);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27169;
		public bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer._isEmpty27169);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._isEmpty27169);
		}
		internal static global::MonoJavaBridge.MethodId _capacity27170;
		public int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer._capacity27170);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._capacity27170);
		}
		internal static global::MonoJavaBridge.MethodId _setLength27171;
		public void setLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer._setLength27171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._setLength27171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray27172;
		public byte[] toByteArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer._toByteArray27172)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._toByteArray27172)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _buffer27173;
		public byte[] buffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer._buffer27173)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._buffer27173)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _isFull27174;
		public bool isFull() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer._isFull27174);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._isFull27174);
		}
		internal static global::MonoJavaBridge.MethodId _byteAt27175;
		public int byteAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer._byteAt27175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._byteAt27175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayBuffer27176;
		public ByteArrayBuffer(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.util.ByteArrayBuffer.staticClass, global::org.apache.http.util.ByteArrayBuffer._ByteArrayBuffer27176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.ByteArrayBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/ByteArrayBuffer"));
			global::org.apache.http.util.ByteArrayBuffer._append27163 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "([BII)V");
			global::org.apache.http.util.ByteArrayBuffer._append27164 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "(I)V");
			global::org.apache.http.util.ByteArrayBuffer._append27165 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "([CII)V");
			global::org.apache.http.util.ByteArrayBuffer._append27166 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "append", "(Lorg/apache/http/util/CharArrayBuffer;II)V");
			global::org.apache.http.util.ByteArrayBuffer._clear27167 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "clear", "()V");
			global::org.apache.http.util.ByteArrayBuffer._length27168 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "length", "()I");
			global::org.apache.http.util.ByteArrayBuffer._isEmpty27169 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "isEmpty", "()Z");
			global::org.apache.http.util.ByteArrayBuffer._capacity27170 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "capacity", "()I");
			global::org.apache.http.util.ByteArrayBuffer._setLength27171 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "setLength", "(I)V");
			global::org.apache.http.util.ByteArrayBuffer._toByteArray27172 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "toByteArray", "()[B");
			global::org.apache.http.util.ByteArrayBuffer._buffer27173 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "buffer", "()[B");
			global::org.apache.http.util.ByteArrayBuffer._isFull27174 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "isFull", "()Z");
			global::org.apache.http.util.ByteArrayBuffer._byteAt27175 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "byteAt", "(I)I");
			global::org.apache.http.util.ByteArrayBuffer._ByteArrayBuffer27176 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.ByteArrayBuffer.staticClass, "<init>", "(I)V");
		}
	}
}
