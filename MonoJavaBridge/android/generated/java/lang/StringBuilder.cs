namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class StringBuilder : java.lang.AbstractStringBuilder, java.io.Serializable, CharSequence
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal StringBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.StringBuilder.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.StringBuilder._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::java.lang.StringBuilder append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.lang.StringBuilder append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.StringBuilder append(char[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "append", "([C)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.lang.StringBuilder append(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "append", "(Z)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::java.lang.StringBuilder append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "append", "(C)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.lang.StringBuilder append(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "append", "(I)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.lang.StringBuilder append(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "append", "(J)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::java.lang.StringBuilder append(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "append", "(F)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::java.lang.StringBuilder append(double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "append", "(D)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public global::java.lang.StringBuilder append(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "append", "([CII)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public global::java.lang.StringBuilder append(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::java.lang.StringBuilder append(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.lang.StringBuilder append(java.lang.StringBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public sealed override int indexOf(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuilder.staticClass, "indexOf", "(Ljava/lang/String;)I", ref global::java.lang.StringBuilder._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public sealed override int indexOf(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuilder.staticClass, "indexOf", "(Ljava/lang/String;I)I", ref global::java.lang.StringBuilder._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public sealed override int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuilder.staticClass, "length", "()I", ref global::java.lang.StringBuilder._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public sealed override char charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.lang.StringBuilder.staticClass, "charAt", "(I)C", ref global::java.lang.StringBuilder._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public sealed override int lastIndexOf(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I", ref global::java.lang.StringBuilder._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public sealed override int lastIndexOf(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;)I", ref global::java.lang.StringBuilder._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public sealed override global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::java.lang.StringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::java.lang.StringBuilder._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public global::java.lang.StringBuilder replace(int arg0, int arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public global::java.lang.StringBuilder appendCodePoint(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "appendCodePoint", "(I)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public global::java.lang.StringBuilder delete(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "delete", "(II)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public global::java.lang.StringBuilder deleteCharAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "deleteCharAt", "(I)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public global::java.lang.StringBuilder insert(int arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "insert", "(ID)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public global::java.lang.StringBuilder insert(int arg0, char[] arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "insert", "(I[CII)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public global::java.lang.StringBuilder insert(int arg0, char[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "insert", "(I[C)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.CharSequence arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public global::java.lang.StringBuilder insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.lang.StringBuilder;
		}
		public java.lang.StringBuilder insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public global::java.lang.StringBuilder insert(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "insert", "(IZ)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public global::java.lang.StringBuilder insert(int arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "insert", "(IC)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public global::java.lang.StringBuilder insert(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "insert", "(II)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public global::java.lang.StringBuilder insert(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "insert", "(IJ)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public global::java.lang.StringBuilder insert(int arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "insert", "(IF)Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public global::java.lang.StringBuilder reverse()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuilder>(this, global::java.lang.StringBuilder.staticClass, "reverse", "()Ljava/lang/StringBuilder;", ref global::java.lang.StringBuilder._m37) as java.lang.StringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public StringBuilder(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.StringBuilder._m38.native == global::System.IntPtr.Zero)
				global::java.lang.StringBuilder._m38 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public StringBuilder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.StringBuilder._m39.native == global::System.IntPtr.Zero)
				global::java.lang.StringBuilder._m39 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._m39);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public StringBuilder(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.StringBuilder._m40.native == global::System.IntPtr.Zero)
				global::java.lang.StringBuilder._m40 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public StringBuilder(java.lang.CharSequence arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.StringBuilder._m41.native == global::System.IntPtr.Zero)
				global::java.lang.StringBuilder._m41 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringBuilder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StringBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StringBuilder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
