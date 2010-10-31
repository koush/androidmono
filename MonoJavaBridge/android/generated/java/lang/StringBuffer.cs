namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class StringBuffer : java.lang.AbstractStringBuilder, java.io.Serializable, CharSequence
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal StringBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.StringBuffer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.StringBuffer._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::java.lang.StringBuffer append(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "append", "([CII)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.lang.StringBuffer append(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.StringBuffer append(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.lang.StringBuffer append(java.lang.StringBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::java.lang.StringBuffer append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.lang.StringBuffer append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.lang.StringBuffer append(char[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "append", "([C)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::java.lang.StringBuffer append(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "append", "(Z)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::java.lang.StringBuffer append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "append", "(C)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public global::java.lang.StringBuffer append(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "append", "(I)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public global::java.lang.StringBuffer append(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "append", "(J)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::java.lang.StringBuffer append(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "append", "(F)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.lang.StringBuffer append(double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "append", "(D)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public sealed override int indexOf(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuffer.staticClass, "indexOf", "(Ljava/lang/String;I)I", ref global::java.lang.StringBuffer._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public sealed override int indexOf(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuffer.staticClass, "indexOf", "(Ljava/lang/String;)I", ref global::java.lang.StringBuffer._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public sealed override int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuffer.staticClass, "length", "()I", ref global::java.lang.StringBuffer._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public sealed override char charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.lang.StringBuffer.staticClass, "charAt", "(I)C", ref global::java.lang.StringBuffer._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public sealed override int codePointAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuffer.staticClass, "codePointAt", "(I)I", ref global::java.lang.StringBuffer._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public sealed override int codePointBefore(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuffer.staticClass, "codePointBefore", "(I)I", ref global::java.lang.StringBuffer._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public sealed override int codePointCount(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuffer.staticClass, "codePointCount", "(II)I", ref global::java.lang.StringBuffer._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public sealed override int offsetByCodePoints(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuffer.staticClass, "offsetByCodePoints", "(II)I", ref global::java.lang.StringBuffer._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public sealed override void getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.StringBuffer.staticClass, "getChars", "(II[CI)V", ref global::java.lang.StringBuffer._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public sealed override int lastIndexOf(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuffer.staticClass, "lastIndexOf", "(Ljava/lang/String;)I", ref global::java.lang.StringBuffer._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public sealed override int lastIndexOf(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuffer.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I", ref global::java.lang.StringBuffer._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public sealed override global::java.lang.String substring(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.StringBuffer.staticClass, "substring", "(I)Ljava/lang/String;", ref global::java.lang.StringBuffer._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public sealed override global::java.lang.String substring(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.StringBuffer.staticClass, "substring", "(II)Ljava/lang/String;", ref global::java.lang.StringBuffer._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public sealed override global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::java.lang.StringBuffer.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::java.lang.StringBuffer._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public global::java.lang.StringBuffer replace(int arg0, int arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public sealed override void trimToSize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.StringBuffer.staticClass, "trimToSize", "()V", ref global::java.lang.StringBuffer._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public sealed override void ensureCapacity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.StringBuffer.staticClass, "ensureCapacity", "(I)V", ref global::java.lang.StringBuffer._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public sealed override int capacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StringBuffer.staticClass, "capacity", "()I", ref global::java.lang.StringBuffer._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public sealed override void setLength(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.StringBuffer.staticClass, "setLength", "(I)V", ref global::java.lang.StringBuffer._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public sealed override void setCharAt(int arg0, char arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.StringBuffer.staticClass, "setCharAt", "(IC)V", ref global::java.lang.StringBuffer._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public global::java.lang.StringBuffer appendCodePoint(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "appendCodePoint", "(I)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public global::java.lang.StringBuffer delete(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "delete", "(II)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public global::java.lang.StringBuffer deleteCharAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "deleteCharAt", "(I)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public global::java.lang.StringBuffer insert(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "insert", "(II)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public global::java.lang.StringBuffer insert(int arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "insert", "(IC)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public global::java.lang.StringBuffer insert(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "insert", "(IZ)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.CharSequence arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuffer;
		}
		public java.lang.StringBuffer insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public global::java.lang.StringBuffer insert(int arg0, char[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "insert", "(I[C)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public global::java.lang.StringBuffer insert(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public global::java.lang.StringBuffer insert(int arg0, char[] arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "insert", "(I[CII)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public global::java.lang.StringBuffer insert(int arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "insert", "(ID)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public global::java.lang.StringBuffer insert(int arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "insert", "(IF)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public global::java.lang.StringBuffer insert(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "insert", "(IJ)Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public global::java.lang.StringBuffer reverse()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.lang.StringBuffer.staticClass, "reverse", "()Ljava/lang/StringBuffer;", ref global::java.lang.StringBuffer._m49) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public StringBuffer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.StringBuffer._m50.native == global::System.IntPtr.Zero)
				global::java.lang.StringBuffer._m50 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._m50);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public StringBuffer(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.StringBuffer._m51.native == global::System.IntPtr.Zero)
				global::java.lang.StringBuffer._m51 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public StringBuffer(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.StringBuffer._m52.native == global::System.IntPtr.Zero)
				global::java.lang.StringBuffer._m52 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public StringBuffer(java.lang.CharSequence arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.StringBuffer._m53.native == global::System.IntPtr.Zero)
				global::java.lang.StringBuffer._m53 = @__env.GetMethodIDNoThrow(global::java.lang.StringBuffer.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringBuffer.staticClass, global::java.lang.StringBuffer._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StringBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StringBuffer"));
		}
	}
}
