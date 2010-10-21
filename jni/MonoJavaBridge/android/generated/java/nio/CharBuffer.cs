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
		internal static global::MonoJavaBridge.MethodId _get22000;
		public virtual global::java.nio.CharBuffer get(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._get22000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._get22000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22001;
		public virtual global::java.nio.CharBuffer get(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._get22001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._get22001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22002;
		public abstract char get();
		internal static global::MonoJavaBridge.MethodId _get22003;
		public abstract char get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22004;
		public abstract global::java.nio.CharBuffer put(int arg0, char arg1);
		internal static global::MonoJavaBridge.MethodId _put22005;
		public abstract global::java.nio.CharBuffer put(char arg0);
		internal static global::MonoJavaBridge.MethodId _put22006;
		public virtual global::java.nio.CharBuffer put(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put22006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put22006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22007;
		public virtual global::java.nio.CharBuffer put(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put22007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put22007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22008;
		public virtual global::java.nio.CharBuffer put(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put22008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put22008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22009;
		public virtual global::java.nio.CharBuffer put(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put22009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put22009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22010;
		public virtual global::java.nio.CharBuffer put(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put22010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put22010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22011;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer._equals22011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._equals22011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22012;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._toString22012)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._toString22012)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append22013;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._append22013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append22013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append22014;
		public virtual global::java.lang.Appendable append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._append22014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append22014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append22015;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._append22015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append22015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22016;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._hashCode22016);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._hashCode22016);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22017;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._compareTo22017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._compareTo22017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22018;
		public virtual int compareTo(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._compareTo22018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._compareTo22018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length22019;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._length22019);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._length22019);
		}
		internal static global::MonoJavaBridge.MethodId _charAt22020;
		public virtual char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.CharBuffer._charAt22020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._charAt22020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence22021;
		public abstract global::java.lang.CharSequence subSequence(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _isDirect22022;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22023;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer._hasArray22023);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._hasArray22023);
		}
		internal static global::MonoJavaBridge.MethodId _array22024;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._array22024)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._array22024)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22025;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._arrayOffset22025);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._arrayOffset22025);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22026;
		public static global::java.nio.CharBuffer wrap(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap22026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22027;
		public static global::java.nio.CharBuffer wrap(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap22027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22028;
		public static global::java.nio.CharBuffer wrap(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap22028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22029;
		public static global::java.nio.CharBuffer wrap(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap22029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _read22030;
		public virtual int read(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._read22030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._read22030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _allocate22031;
		public static global::java.nio.CharBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._allocate22031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22032;
		public abstract global::java.nio.CharBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice22033;
		public abstract global::java.nio.CharBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22034;
		public abstract global::java.nio.CharBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22035;
		public abstract global::java.nio.CharBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22036;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.CharBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/CharBuffer"));
			global::java.nio.CharBuffer._get22000 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "get", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._get22001 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "get", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._get22002 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "get", "()C");
			global::java.nio.CharBuffer._get22003 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "get", "(I)C");
			global::java.nio.CharBuffer._put22004 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(IC)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put22005 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put22006 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put22007 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;II)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put22008 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put22009 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put22010 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/nio/CharBuffer;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._equals22011 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.CharBuffer._toString22012 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.CharBuffer._append22013 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._append22014 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._append22015 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._hashCode22016 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "hashCode", "()I");
			global::java.nio.CharBuffer._compareTo22017 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.CharBuffer._compareTo22018 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/nio/CharBuffer;)I");
			global::java.nio.CharBuffer._length22019 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "length", "()I");
			global::java.nio.CharBuffer._charAt22020 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "charAt", "(I)C");
			global::java.nio.CharBuffer._subSequence22021 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.nio.CharBuffer._isDirect22022 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.CharBuffer._hasArray22023 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.CharBuffer._array22024 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.CharBuffer._arrayOffset22025 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.CharBuffer._wrap22026 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap22027 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap22028 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap22029 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._read22030 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "read", "(Ljava/nio/CharBuffer;)I");
			global::java.nio.CharBuffer._allocate22031 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "allocate", "(I)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._duplicate22032 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "duplicate", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._slice22033 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "slice", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._asReadOnlyBuffer22034 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._compact22035 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "compact", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._order22036 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
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
		internal static global::MonoJavaBridge.MethodId _get22037;
		public override char get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.CharBuffer_._get22037);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._get22037);
		}
		internal static global::MonoJavaBridge.MethodId _get22038;
		public override char get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.CharBuffer_._get22038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._get22038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22039;
		public override global::java.nio.CharBuffer put(int arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._put22039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._put22039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22040;
		public override global::java.nio.CharBuffer put(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._put22040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._put22040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _subSequence22041;
		public override global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._subSequence22041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._subSequence22041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22042;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer_._isDirect22042);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._isDirect22042);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22043;
		public override global::java.nio.CharBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._duplicate22043)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._duplicate22043)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22044;
		public override global::java.nio.CharBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._slice22044)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._slice22044)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22045;
		public override global::java.nio.CharBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._asReadOnlyBuffer22045)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._asReadOnlyBuffer22045)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22046;
		public override global::java.nio.CharBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._compact22046)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._compact22046)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22047;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._order22047)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._order22047)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22048;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer_._isReadOnly22048);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._isReadOnly22048);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.CharBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/CharBuffer"));
			global::java.nio.CharBuffer_._get22037 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "get", "()C");
			global::java.nio.CharBuffer_._get22038 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "get", "(I)C");
			global::java.nio.CharBuffer_._put22039 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "put", "(IC)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._put22040 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "put", "(C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._subSequence22041 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.nio.CharBuffer_._isDirect22042 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.CharBuffer_._duplicate22043 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "duplicate", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._slice22044 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "slice", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._asReadOnlyBuffer22045 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._compact22046 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "compact", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._order22047 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.CharBuffer_._isReadOnly22048 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
