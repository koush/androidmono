namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CharArrayBuffer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharArrayBuffer()
		{
			InitJNI();
		}
		internal CharArrayBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString27177;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._toString27177)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._toString27177)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append27178;
		public void append(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append27178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append27178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append27179;
		public void append(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append27179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append27179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append27180;
		public void append(org.apache.http.util.CharArrayBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append27180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append27180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append27181;
		public void append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append27181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append27181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append27182;
		public void append(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append27182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append27182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append27183;
		public void append(org.apache.http.util.ByteArrayBuffer arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append27183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append27183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append27184;
		public void append(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append27184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append27184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append27185;
		public void append(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append27185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append27185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf27186;
		public int indexOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._indexOf27186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._indexOf27186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf27187;
		public int indexOf(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._indexOf27187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._indexOf27187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clear27188;
		public void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._clear27188);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._clear27188);
		}
		internal static global::MonoJavaBridge.MethodId _length27189;
		public int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._length27189);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._length27189);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27190;
		public bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._isEmpty27190);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._isEmpty27190);
		}
		internal static global::MonoJavaBridge.MethodId _charAt27191;
		public char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._charAt27191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._charAt27191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _substring27192;
		public global::java.lang.String substring(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._substring27192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._substring27192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toCharArray27193;
		public char[] toCharArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._toCharArray27193)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._toCharArray27193)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity27194;
		public void ensureCapacity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._ensureCapacity27194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._ensureCapacity27194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _capacity27195;
		public int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._capacity27195);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._capacity27195);
		}
		internal static global::MonoJavaBridge.MethodId _setLength27196;
		public void setLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._setLength27196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._setLength27196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _buffer27197;
		public char[] buffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._buffer27197)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._buffer27197)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _isFull27198;
		public bool isFull() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._isFull27198);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._isFull27198);
		}
		internal static global::MonoJavaBridge.MethodId _substringTrimmed27199;
		public global::java.lang.String substringTrimmed(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._substringTrimmed27199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._substringTrimmed27199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayBuffer27200;
		public CharArrayBuffer(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._CharArrayBuffer27200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.CharArrayBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/CharArrayBuffer"));
			global::org.apache.http.util.CharArrayBuffer._toString27177 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.util.CharArrayBuffer._append27178 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Ljava/lang/String;)V");
			global::org.apache.http.util.CharArrayBuffer._append27179 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Lorg/apache/http/util/CharArrayBuffer;II)V");
			global::org.apache.http.util.CharArrayBuffer._append27180 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Lorg/apache/http/util/CharArrayBuffer;)V");
			global::org.apache.http.util.CharArrayBuffer._append27181 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(C)V");
			global::org.apache.http.util.CharArrayBuffer._append27182 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "([BII)V");
			global::org.apache.http.util.CharArrayBuffer._append27183 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Lorg/apache/http/util/ByteArrayBuffer;II)V");
			global::org.apache.http.util.CharArrayBuffer._append27184 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Ljava/lang/Object;)V");
			global::org.apache.http.util.CharArrayBuffer._append27185 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "([CII)V");
			global::org.apache.http.util.CharArrayBuffer._indexOf27186 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "indexOf", "(I)I");
			global::org.apache.http.util.CharArrayBuffer._indexOf27187 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "indexOf", "(III)I");
			global::org.apache.http.util.CharArrayBuffer._clear27188 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "clear", "()V");
			global::org.apache.http.util.CharArrayBuffer._length27189 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "length", "()I");
			global::org.apache.http.util.CharArrayBuffer._isEmpty27190 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "isEmpty", "()Z");
			global::org.apache.http.util.CharArrayBuffer._charAt27191 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "charAt", "(I)C");
			global::org.apache.http.util.CharArrayBuffer._substring27192 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "substring", "(II)Ljava/lang/String;");
			global::org.apache.http.util.CharArrayBuffer._toCharArray27193 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "toCharArray", "()[C");
			global::org.apache.http.util.CharArrayBuffer._ensureCapacity27194 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "ensureCapacity", "(I)V");
			global::org.apache.http.util.CharArrayBuffer._capacity27195 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "capacity", "()I");
			global::org.apache.http.util.CharArrayBuffer._setLength27196 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "setLength", "(I)V");
			global::org.apache.http.util.CharArrayBuffer._buffer27197 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "buffer", "()[C");
			global::org.apache.http.util.CharArrayBuffer._isFull27198 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "isFull", "()Z");
			global::org.apache.http.util.CharArrayBuffer._substringTrimmed27199 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "substringTrimmed", "(II)Ljava/lang/String;");
			global::org.apache.http.util.CharArrayBuffer._CharArrayBuffer27200 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "<init>", "(I)V");
		}
	}
}
