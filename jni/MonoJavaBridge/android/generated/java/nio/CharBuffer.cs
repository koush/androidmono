namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.CharBuffer_))]
	public abstract partial class CharBuffer : java.nio.Buffer, java.lang.Comparable, java.lang.Appendable, java.lang.CharSequence, java.lang.Readable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharBuffer()
		{
			InitJNI();
		}
		protected CharBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get16406;
		public virtual global::java.nio.CharBuffer get(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._get16406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._get16406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get16407;
		public virtual global::java.nio.CharBuffer get(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._get16407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._get16407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get16408;
		public abstract char get();
		internal static global::MonoJavaBridge.MethodId _get16409;
		public abstract char get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put16410;
		public abstract global::java.nio.CharBuffer put(int arg0, char arg1);
		internal static global::MonoJavaBridge.MethodId _put16411;
		public abstract global::java.nio.CharBuffer put(char arg0);
		internal static global::MonoJavaBridge.MethodId _put16412;
		public virtual global::java.nio.CharBuffer put(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put16412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put16412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16413;
		public virtual global::java.nio.CharBuffer put(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put16413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put16413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16414;
		public virtual global::java.nio.CharBuffer put(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put16414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put16414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16415;
		public virtual global::java.nio.CharBuffer put(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put16415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put16415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16416;
		public virtual global::java.nio.CharBuffer put(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put16416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put16416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals16417;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer._equals16417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._equals16417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString16418;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._toString16418)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._toString16418)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append16419;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._append16419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append16419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append16420;
		public virtual global::java.lang.Appendable append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._append16420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append16420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append16421;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._append16421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append16421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _hashCode16422;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._hashCode16422);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._hashCode16422);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16423;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._compareTo16423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._compareTo16423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16424;
		public virtual int compareTo(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._compareTo16424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._compareTo16424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length16425;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._length16425);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._length16425);
		}
		internal static global::MonoJavaBridge.MethodId _charAt16426;
		public virtual char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.CharBuffer._charAt16426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._charAt16426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence16427;
		public abstract global::java.lang.CharSequence subSequence(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _isDirect16428;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray16429;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer._hasArray16429);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._hasArray16429);
		}
		internal static global::MonoJavaBridge.MethodId _array16430;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._array16430)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._array16430)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset16431;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._arrayOffset16431);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._arrayOffset16431);
		}
		internal static global::MonoJavaBridge.MethodId _wrap16432;
		public static global::java.nio.CharBuffer wrap(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap16432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap16433;
		public static global::java.nio.CharBuffer wrap(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap16433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap16434;
		public static global::java.nio.CharBuffer wrap(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap16434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap16435;
		public static global::java.nio.CharBuffer wrap(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap16435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _read16436;
		public virtual int read(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._read16436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._read16436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _allocate16437;
		public static global::java.nio.CharBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._allocate16437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16438;
		public abstract global::java.nio.CharBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice16439;
		public abstract global::java.nio.CharBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16440;
		public abstract global::java.nio.CharBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact16441;
		public abstract global::java.nio.CharBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order16442;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.CharBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/CharBuffer"));
			global::java.nio.CharBuffer._get16406 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "get", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._get16407 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "get", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._get16408 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "get", "()C");
			global::java.nio.CharBuffer._get16409 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "get", "(I)C");
			global::java.nio.CharBuffer._put16410 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(IC)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put16411 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put16412 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put16413 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;II)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put16414 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put16415 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put16416 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/nio/CharBuffer;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._equals16417 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.CharBuffer._toString16418 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.CharBuffer._append16419 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._append16420 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._append16421 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._hashCode16422 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "hashCode", "()I");
			global::java.nio.CharBuffer._compareTo16423 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.CharBuffer._compareTo16424 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/nio/CharBuffer;)I");
			global::java.nio.CharBuffer._length16425 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "length", "()I");
			global::java.nio.CharBuffer._charAt16426 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "charAt", "(I)C");
			global::java.nio.CharBuffer._subSequence16427 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.nio.CharBuffer._isDirect16428 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.CharBuffer._hasArray16429 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.CharBuffer._array16430 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.CharBuffer._arrayOffset16431 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.CharBuffer._wrap16432 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap16433 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap16434 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap16435 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._read16436 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "read", "(Ljava/nio/CharBuffer;)I");
			global::java.nio.CharBuffer._allocate16437 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "allocate", "(I)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._duplicate16438 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "duplicate", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._slice16439 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "slice", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._asReadOnlyBuffer16440 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._compact16441 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "compact", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._order16442 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.CharBuffer))]
	public sealed partial class CharBuffer_ : java.nio.CharBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharBuffer_()
		{
			InitJNI();
		}
		internal CharBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get16443;
		public override char get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.CharBuffer_._get16443);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._get16443);
		}
		internal static global::MonoJavaBridge.MethodId _get16444;
		public override char get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.CharBuffer_._get16444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._get16444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put16445;
		public override global::java.nio.CharBuffer put(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._put16445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._put16445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16446;
		public override global::java.nio.CharBuffer put(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._put16446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._put16446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _subSequence16447;
		public override global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._subSequence16447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._subSequence16447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect16448;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer_._isDirect16448);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._isDirect16448);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16449;
		public override global::java.nio.CharBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._duplicate16449)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._duplicate16449)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice16450;
		public override global::java.nio.CharBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._slice16450)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._slice16450)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16451;
		public override global::java.nio.CharBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._asReadOnlyBuffer16451)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._asReadOnlyBuffer16451)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact16452;
		public override global::java.nio.CharBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._compact16452)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._compact16452)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order16453;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._order16453)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._order16453)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly16454;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer_._isReadOnly16454);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._isReadOnly16454);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.CharBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/CharBuffer"));
			global::java.nio.CharBuffer_._get16443 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "get", "()C");
			global::java.nio.CharBuffer_._get16444 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "get", "(I)C");
			global::java.nio.CharBuffer_._put16445 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "put", "(IC)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._put16446 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "put", "(C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._subSequence16447 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.nio.CharBuffer_._isDirect16448 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.CharBuffer_._duplicate16449 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "duplicate", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._slice16450 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "slice", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._asReadOnlyBuffer16451 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._compact16452 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "compact", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._order16453 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.CharBuffer_._isReadOnly16454 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
