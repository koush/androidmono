namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.CharBuffer_))]
	public abstract partial class CharBuffer : java.nio.Buffer, java.lang.Comparable, java.lang.Appendable, java.lang.CharSequence, java.lang.Readable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CharBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22119;
		public virtual global::java.nio.CharBuffer get(char[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "get", "([C)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer._get22119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22120;
		public virtual global::java.nio.CharBuffer get(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "get", "([CII)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer._get22120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.CharBuffer;
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer._put22125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22126;
		public virtual global::java.nio.CharBuffer put(java.lang.String arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;II)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer._put22126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22127;
		public virtual global::java.nio.CharBuffer put(char[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "put", "([C)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer._put22127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22128;
		public virtual global::java.nio.CharBuffer put(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "put", "([CII)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer._put22128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22129;
		public virtual global::java.nio.CharBuffer put(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "put", "(Ljava/nio/CharBuffer;)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer._put22129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22130;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.CharBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.nio.CharBuffer._equals22130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22131;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.CharBuffer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.CharBuffer._toString22131) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append22132;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", ref global::java.nio.CharBuffer._append22132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append22133;
		public virtual global::java.lang.Appendable append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.nio.CharBuffer.staticClass, "append", "(C)Ljava/lang/Appendable;", ref global::java.nio.CharBuffer._append22133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append22134;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", ref global::java.nio.CharBuffer._append22134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22135;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.CharBuffer.staticClass, "hashCode", "()I", ref global::java.nio.CharBuffer._hashCode22135);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22136;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.nio.CharBuffer._compareTo22136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22137;
		public virtual int compareTo(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/nio/CharBuffer;)I", ref global::java.nio.CharBuffer._compareTo22137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length22138;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.CharBuffer.staticClass, "length", "()I", ref global::java.nio.CharBuffer._length22138);
		}
		internal static global::MonoJavaBridge.MethodId _charAt22139;
		public virtual char charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.nio.CharBuffer.staticClass, "charAt", "(I)C", ref global::java.nio.CharBuffer._charAt22139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence22140;
		public abstract global::java.lang.CharSequence subSequence(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _isDirect22141;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22142;
		public sealed override bool hasArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.CharBuffer.staticClass, "hasArray", "()Z", ref global::java.nio.CharBuffer._hasArray22142);
		}
		internal static global::MonoJavaBridge.MethodId _array22143;
		public override global::java.lang.Object array()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "array", "()Ljava/lang/Object;", ref global::java.nio.CharBuffer._array22143) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22144;
		public sealed override int arrayOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.CharBuffer.staticClass, "arrayOffset", "()I", ref global::java.nio.CharBuffer._arrayOffset22144);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22145;
		public static global::java.nio.CharBuffer wrap(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.CharBuffer._wrap22145.native == global::System.IntPtr.Zero)
				global::java.nio.CharBuffer._wrap22145 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;");
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
			if (global::java.nio.CharBuffer._wrap22146.native == global::System.IntPtr.Zero)
				global::java.nio.CharBuffer._wrap22146 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "([CII)Ljava/nio/CharBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap22146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22147;
		public static global::java.nio.CharBuffer wrap(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.CharBuffer._wrap22147.native == global::System.IntPtr.Zero)
				global::java.nio.CharBuffer._wrap22147 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "([C)Ljava/nio/CharBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap22147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22148;
		public static global::java.nio.CharBuffer wrap(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.CharBuffer._wrap22148.native == global::System.IntPtr.Zero)
				global::java.nio.CharBuffer._wrap22148 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._wrap22148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		public static java.nio.CharBuffer wrap(string arg0)
		{
			return wrap((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _read22149;
		public virtual int read(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.CharBuffer.staticClass, "read", "(Ljava/nio/CharBuffer;)I", ref global::java.nio.CharBuffer._read22149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _allocate22150;
		public static global::java.nio.CharBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.CharBuffer._allocate22150.native == global::System.IntPtr.Zero)
				global::java.nio.CharBuffer._allocate22150 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "allocate", "(I)Ljava/nio/CharBuffer;");
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
		static CharBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.CharBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/CharBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.CharBuffer))]
	internal sealed partial class CharBuffer_ : java.nio.CharBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CharBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22156;
		public override char get()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.nio.CharBuffer_.staticClass, "get", "()C", ref global::java.nio.CharBuffer_._get22156);
		}
		internal static global::MonoJavaBridge.MethodId _get22157;
		public override char get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.nio.CharBuffer_.staticClass, "get", "(I)C", ref global::java.nio.CharBuffer_._get22157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22158;
		public override global::java.nio.CharBuffer put(int arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer_.staticClass, "put", "(IC)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer_._put22158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22159;
		public override global::java.nio.CharBuffer put(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer_.staticClass, "put", "(C)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer_._put22159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _subSequence22160;
		public override global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::java.nio.CharBuffer_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::java.nio.CharBuffer_._subSequence22160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22161;
		public override bool isDirect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.CharBuffer_.staticClass, "isDirect", "()Z", ref global::java.nio.CharBuffer_._isDirect22161);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22162;
		public override global::java.nio.CharBuffer duplicate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer_.staticClass, "duplicate", "()Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer_._duplicate22162) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22163;
		public override global::java.nio.CharBuffer slice()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer_.staticClass, "slice", "()Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer_._slice22163) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22164;
		public override global::java.nio.CharBuffer asReadOnlyBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer_._asReadOnlyBuffer22164) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22165;
		public override global::java.nio.CharBuffer compact()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer_.staticClass, "compact", "()Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer_._compact22165) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22166;
		public override global::java.nio.ByteOrder order()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.nio.ByteOrder>(this, global::java.nio.CharBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;", ref global::java.nio.CharBuffer_._order22166) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22167;
		public override bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.CharBuffer_.staticClass, "isReadOnly", "()Z", ref global::java.nio.CharBuffer_._isReadOnly22167);
		}
		static CharBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.CharBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/CharBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
