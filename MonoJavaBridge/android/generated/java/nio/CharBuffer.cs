namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.CharBuffer_))]
	public abstract partial class CharBuffer : java.nio.Buffer, java.lang.Comparable, java.lang.Appendable, java.lang.CharSequence, java.lang.Readable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CharBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.nio.CharBuffer get(char[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "get", "([C)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.nio.CharBuffer get(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "get", "([CII)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract char get();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract char get(int arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.nio.CharBuffer put(int arg0, char arg1);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.nio.CharBuffer put(char arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.nio.CharBuffer put(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.nio.CharBuffer put(java.lang.String arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "put", "(Ljava/lang/String;II)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.nio.CharBuffer put(char[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "put", "([C)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.nio.CharBuffer put(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "put", "([CII)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.nio.CharBuffer put(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "put", "(Ljava/nio/CharBuffer;)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.CharBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.nio.CharBuffer._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.CharBuffer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.CharBuffer._m12) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", ref global::java.nio.CharBuffer._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.lang.Appendable append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.nio.CharBuffer.staticClass, "append", "(C)Ljava/lang/Appendable;", ref global::java.nio.CharBuffer._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.nio.CharBuffer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", ref global::java.nio.CharBuffer._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.CharBuffer.staticClass, "hashCode", "()I", ref global::java.nio.CharBuffer._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.nio.CharBuffer._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual int compareTo(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.CharBuffer.staticClass, "compareTo", "(Ljava/nio/CharBuffer;)I", ref global::java.nio.CharBuffer._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.CharBuffer.staticClass, "length", "()I", ref global::java.nio.CharBuffer._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual char charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.nio.CharBuffer.staticClass, "charAt", "(I)C", ref global::java.nio.CharBuffer._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract global::java.lang.CharSequence subSequence(int arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract bool isDirect();
		private static global::MonoJavaBridge.MethodId _m23;
		public sealed override bool hasArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.CharBuffer.staticClass, "hasArray", "()Z", ref global::java.nio.CharBuffer._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public override global::java.lang.Object array()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer.staticClass, "array", "()Ljava/lang/Object;", ref global::java.nio.CharBuffer._m24) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public sealed override int arrayOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.CharBuffer.staticClass, "arrayOffset", "()I", ref global::java.nio.CharBuffer._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static global::java.nio.CharBuffer wrap(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.CharBuffer._m26.native == global::System.IntPtr.Zero)
				global::java.nio.CharBuffer._m26 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		public static java.nio.CharBuffer wrap(string arg0, int arg1, int arg2)
		{
			return wrap((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static global::java.nio.CharBuffer wrap(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.CharBuffer._m27.native == global::System.IntPtr.Zero)
				global::java.nio.CharBuffer._m27 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "([CII)Ljava/nio/CharBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static global::java.nio.CharBuffer wrap(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.CharBuffer._m28.native == global::System.IntPtr.Zero)
				global::java.nio.CharBuffer._m28 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "([C)Ljava/nio/CharBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static global::java.nio.CharBuffer wrap(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.CharBuffer._m29.native == global::System.IntPtr.Zero)
				global::java.nio.CharBuffer._m29 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "wrap", "(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		public static java.nio.CharBuffer wrap(string arg0)
		{
			return wrap((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual int read(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.CharBuffer.staticClass, "read", "(Ljava/nio/CharBuffer;)I", ref global::java.nio.CharBuffer._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static global::java.nio.CharBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.CharBuffer._m31.native == global::System.IntPtr.Zero)
				global::java.nio.CharBuffer._m31 = @__env.GetStaticMethodIDNoThrow(global::java.nio.CharBuffer.staticClass, "allocate", "(I)Ljava/nio/CharBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.CharBuffer.staticClass, global::java.nio.CharBuffer._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public abstract global::java.nio.CharBuffer duplicate();
		private static global::MonoJavaBridge.MethodId _m33;
		public abstract global::java.nio.CharBuffer slice();
		private static global::MonoJavaBridge.MethodId _m34;
		public abstract global::java.nio.CharBuffer asReadOnlyBuffer();
		private static global::MonoJavaBridge.MethodId _m35;
		public abstract global::java.nio.CharBuffer compact();
		private static global::MonoJavaBridge.MethodId _m36;
		public abstract global::java.nio.ByteOrder order();
		static CharBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.CharBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/CharBuffer"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.CharBuffer))]
	internal sealed partial class CharBuffer_ : java.nio.CharBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CharBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override char get()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.nio.CharBuffer_.staticClass, "get", "()C", ref global::java.nio.CharBuffer_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override char get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.nio.CharBuffer_.staticClass, "get", "(I)C", ref global::java.nio.CharBuffer_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.nio.CharBuffer put(int arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer_.staticClass, "put", "(IC)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.nio.CharBuffer put(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer_.staticClass, "put", "(C)Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::java.nio.CharBuffer_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::java.nio.CharBuffer_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool isDirect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.CharBuffer_.staticClass, "isDirect", "()Z", ref global::java.nio.CharBuffer_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.nio.CharBuffer duplicate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer_.staticClass, "duplicate", "()Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer_._m6) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.nio.CharBuffer slice()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer_.staticClass, "slice", "()Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer_._m7) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.nio.CharBuffer asReadOnlyBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer_._m8) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.nio.CharBuffer compact()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.CharBuffer_.staticClass, "compact", "()Ljava/nio/CharBuffer;", ref global::java.nio.CharBuffer_._m9) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.nio.ByteOrder order()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.nio.ByteOrder>(this, global::java.nio.CharBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;", ref global::java.nio.CharBuffer_._m10) as java.nio.ByteOrder;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.CharBuffer_.staticClass, "isReadOnly", "()Z", ref global::java.nio.CharBuffer_._m11);
		}
		static CharBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.CharBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/CharBuffer"));
		}
	}
}
