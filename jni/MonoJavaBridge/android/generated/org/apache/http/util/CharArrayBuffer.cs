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
		internal static global::MonoJavaBridge.MethodId _toString33979;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._toString33979)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._toString33979)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append33980;
		public void append(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append33980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append33980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append33981;
		public void append(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append33981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append33981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append33982;
		public void append(org.apache.http.util.CharArrayBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append33982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append33982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append33983;
		public void append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append33983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append33983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append33984;
		public void append(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append33984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append33984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append33985;
		public void append(org.apache.http.util.ByteArrayBuffer arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append33985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append33985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append33986;
		public void append(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append33986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append33986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append33987;
		public void append(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._append33987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._append33987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf33988;
		public int indexOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._indexOf33988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._indexOf33988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf33989;
		public int indexOf(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._indexOf33989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._indexOf33989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clear33990;
		public void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._clear33990);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._clear33990);
		}
		internal static global::MonoJavaBridge.MethodId _length33991;
		public int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._length33991);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._length33991);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty33992;
		public bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._isEmpty33992);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._isEmpty33992);
		}
		internal static global::MonoJavaBridge.MethodId _charAt33993;
		public char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._charAt33993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._charAt33993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _substring33994;
		public global::java.lang.String substring(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._substring33994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._substring33994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toCharArray33995;
		public char[] toCharArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._toCharArray33995)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._toCharArray33995)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity33996;
		public void ensureCapacity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._ensureCapacity33996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._ensureCapacity33996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _capacity33997;
		public int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._capacity33997);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._capacity33997);
		}
		internal static global::MonoJavaBridge.MethodId _setLength33998;
		public void setLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._setLength33998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._setLength33998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _buffer33999;
		public char[] buffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._buffer33999)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._buffer33999)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _isFull34000;
		public bool isFull() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._isFull34000);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._isFull34000);
		}
		internal static global::MonoJavaBridge.MethodId _substringTrimmed34001;
		public global::java.lang.String substringTrimmed(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer._substringTrimmed34001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._substringTrimmed34001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayBuffer34002;
		public CharArrayBuffer(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.util.CharArrayBuffer.staticClass, global::org.apache.http.util.CharArrayBuffer._CharArrayBuffer34002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.CharArrayBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/CharArrayBuffer"));
			global::org.apache.http.util.CharArrayBuffer._toString33979 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.util.CharArrayBuffer._append33980 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Ljava/lang/String;)V");
			global::org.apache.http.util.CharArrayBuffer._append33981 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Lorg/apache/http/util/CharArrayBuffer;II)V");
			global::org.apache.http.util.CharArrayBuffer._append33982 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Lorg/apache/http/util/CharArrayBuffer;)V");
			global::org.apache.http.util.CharArrayBuffer._append33983 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(C)V");
			global::org.apache.http.util.CharArrayBuffer._append33984 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "([BII)V");
			global::org.apache.http.util.CharArrayBuffer._append33985 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Lorg/apache/http/util/ByteArrayBuffer;II)V");
			global::org.apache.http.util.CharArrayBuffer._append33986 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "(Ljava/lang/Object;)V");
			global::org.apache.http.util.CharArrayBuffer._append33987 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "append", "([CII)V");
			global::org.apache.http.util.CharArrayBuffer._indexOf33988 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "indexOf", "(I)I");
			global::org.apache.http.util.CharArrayBuffer._indexOf33989 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "indexOf", "(III)I");
			global::org.apache.http.util.CharArrayBuffer._clear33990 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "clear", "()V");
			global::org.apache.http.util.CharArrayBuffer._length33991 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "length", "()I");
			global::org.apache.http.util.CharArrayBuffer._isEmpty33992 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "isEmpty", "()Z");
			global::org.apache.http.util.CharArrayBuffer._charAt33993 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "charAt", "(I)C");
			global::org.apache.http.util.CharArrayBuffer._substring33994 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "substring", "(II)Ljava/lang/String;");
			global::org.apache.http.util.CharArrayBuffer._toCharArray33995 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "toCharArray", "()[C");
			global::org.apache.http.util.CharArrayBuffer._ensureCapacity33996 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "ensureCapacity", "(I)V");
			global::org.apache.http.util.CharArrayBuffer._capacity33997 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "capacity", "()I");
			global::org.apache.http.util.CharArrayBuffer._setLength33998 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "setLength", "(I)V");
			global::org.apache.http.util.CharArrayBuffer._buffer33999 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "buffer", "()[C");
			global::org.apache.http.util.CharArrayBuffer._isFull34000 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "isFull", "()Z");
			global::org.apache.http.util.CharArrayBuffer._substringTrimmed34001 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "substringTrimmed", "(II)Ljava/lang/String;");
			global::org.apache.http.util.CharArrayBuffer._CharArrayBuffer34002 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.CharArrayBuffer.staticClass, "<init>", "(I)V");
		}
	}
}
