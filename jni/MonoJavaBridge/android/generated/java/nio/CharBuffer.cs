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
		internal static global::MonoJavaBridge.MethodId _get22119;
		public virtual global::java.nio.CharBuffer get(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._get22119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._get22119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22120;
		public virtual global::java.nio.CharBuffer get(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._get22120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._get22120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22121;
		public abstract char get();
		internal static global::MonoJavaBridge.MethodId _get22122;
		public abstract char get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22123;
		public abstract global::java.nio.CharBuffer put(int arg0, char arg1);
		internal static global::MonoJavaBridge.MethodId _put22124;
		public abstract global::java.nio.CharBuffer put(char arg0);
		internal static global::MonoJavaBridge.MethodId _put22125;
		public virtual global::java.nio.CharBuffer put(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put22125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put22125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22126;
		public virtual global::java.nio.CharBuffer put(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put22126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put22126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22127;
		public virtual global::java.nio.CharBuffer put(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put22127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put22127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22128;
		public virtual global::java.nio.CharBuffer put(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put22128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put22128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22129;
		public virtual global::java.nio.CharBuffer put(java.nio.CharBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._put22129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._put22129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22130;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer._equals22130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._equals22130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22131;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._toString22131)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._toString22131)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append22132;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._append22132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append22132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append22133;
		public virtual global::java.lang.Appendable append(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._append22133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append22133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append22134;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._append22134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._append22134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22135;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._hashCode22135);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._hashCode22135);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22136;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._compareTo22136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._compareTo22136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22137;
		public virtual int compareTo(java.nio.CharBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._compareTo22137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._compareTo22137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length22138;
		public virtual int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._length22138);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._length22138);
		}
		internal static global::MonoJavaBridge.MethodId _charAt22139;
		public virtual char charAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.CharBuffer._charAt22139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._charAt22139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence22140;
		public abstract global::java.lang.CharSequence subSequence(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _isDirect22141;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22142;
		public sealed override bool hasArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer._hasArray22142);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._hasArray22142);
		}
		internal static global::MonoJavaBridge.MethodId _array22143;
		public override global::java.lang.Object array()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer._array22143)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._array22143)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22144;
		public sealed override int arrayOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._arrayOffset22144);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._arrayOffset22144);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22145;
		public static global::java.nio.CharBuffer wrap(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap22145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		public static java.nio.CharBuffer wrap(string arg0, int arg1, int arg2)
		{
			return wrap((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22146;
		public static global::java.nio.CharBuffer wrap(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap22146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22147;
		public static global::java.nio.CharBuffer wrap(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap22147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22148;
		public static global::java.nio.CharBuffer wrap(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap22148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		public static java.nio.CharBuffer wrap(string arg0)
		{
			return wrap((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _read22149;
		public virtual int read(java.nio.CharBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.CharBuffer._read22149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._read22149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _allocate22150;
		public static global::java.nio.CharBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._allocate22150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22151;
		public abstract global::java.nio.CharBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice22152;
		public abstract global::java.nio.CharBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22153;
		public abstract global::java.nio.CharBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22154;
		public abstract global::java.nio.CharBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22155;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.CharBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/CharBuffer"));
			global::java.nio.CharBuffer._get22119 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "get", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._get22120 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "get", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._get22121 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "get", "()C");
			global::java.nio.CharBuffer._get22122 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "get", "(I)C");
			global::java.nio.CharBuffer._put22123 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(IC)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put22124 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put22125 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put22126 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;II)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put22127 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put22128 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._put22129 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "put", "(Ljava/nio/CharBuffer;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._equals22130 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.CharBuffer._toString22131 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.CharBuffer._append22132 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._append22133 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._append22134 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.nio.CharBuffer._hashCode22135 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "hashCode", "()I");
			global::java.nio.CharBuffer._compareTo22136 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.CharBuffer._compareTo22137 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/nio/CharBuffer;)I");
			global::java.nio.CharBuffer._length22138 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "length", "()I");
			global::java.nio.CharBuffer._charAt22139 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "charAt", "(I)C");
			global::java.nio.CharBuffer._subSequence22140 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.nio.CharBuffer._isDirect22141 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.CharBuffer._hasArray22142 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.CharBuffer._array22143 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.CharBuffer._arrayOffset22144 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.CharBuffer._wrap22145 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap22146 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "([CII)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap22147 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "([C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._wrap22148 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._read22149 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "read", "(Ljava/nio/CharBuffer;)I");
			global::java.nio.CharBuffer._allocate22150 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "allocate", "(I)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._duplicate22151 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "duplicate", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._slice22152 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "slice", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._asReadOnlyBuffer22153 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._compact22154 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "compact", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer._order22155 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.CharBuffer))]
	internal sealed partial class CharBuffer_ : java.nio.CharBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharBuffer_()
		{
			InitJNI();
		}
		internal CharBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22156;
		public override char get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.CharBuffer_._get22156);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._get22156);
		}
		internal static global::MonoJavaBridge.MethodId _get22157;
		public override char get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.CharBuffer_._get22157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._get22157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22158;
		public override global::java.nio.CharBuffer put(int arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._put22158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._put22158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22159;
		public override global::java.nio.CharBuffer put(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._put22159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._put22159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _subSequence22160;
		public override global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._subSequence22160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._subSequence22160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22161;
		public override bool isDirect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer_._isDirect22161);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._isDirect22161);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22162;
		public override global::java.nio.CharBuffer duplicate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._duplicate22162)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._duplicate22162)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22163;
		public override global::java.nio.CharBuffer slice()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._slice22163)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._slice22163)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22164;
		public override global::java.nio.CharBuffer asReadOnlyBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._asReadOnlyBuffer22164)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._asReadOnlyBuffer22164)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22165;
		public override global::java.nio.CharBuffer compact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._compact22165)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._compact22165)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22166;
		public override global::java.nio.ByteOrder order()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_._order22166)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._order22166)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22167;
		public override bool isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer_._isReadOnly22167);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.CharBuffer_.staticClass, global::java.nio.CharBuffer_._isReadOnly22167);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.CharBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/CharBuffer"));
			global::java.nio.CharBuffer_._get22156 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "get", "()C");
			global::java.nio.CharBuffer_._get22157 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "get", "(I)C");
			global::java.nio.CharBuffer_._put22158 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "put", "(IC)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._put22159 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "put", "(C)Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._subSequence22160 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::java.nio.CharBuffer_._isDirect22161 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.CharBuffer_._duplicate22162 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "duplicate", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._slice22163 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "slice", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._asReadOnlyBuffer22164 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._compact22165 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "compact", "()Ljava/nio/CharBuffer;");
			global::java.nio.CharBuffer_._order22166 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.CharBuffer_._isReadOnly22167 = @__env.GetMethodIDNoThrow(global::java.nio.CharBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
