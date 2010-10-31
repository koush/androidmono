namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class String : java.lang.Object, java.io.Serializable, Comparable, CharSequence
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal String(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.String.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.String._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.String._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "hashCode", "()I", ref global::java.lang.String._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.lang.String._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int compareTo(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "compareTo", "(Ljava/lang/String;)I", ref global::java.lang.String._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int indexOf(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "indexOf", "(I)I", ref global::java.lang.String._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public int indexOf(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "indexOf", "(Ljava/lang/String;I)I", ref global::java.lang.String._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public int indexOf(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "indexOf", "(Ljava/lang/String;)I", ref global::java.lang.String._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public int indexOf(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "indexOf", "(II)I", ref global::java.lang.String._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "length", "()I", ref global::java.lang.String._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.String.staticClass, "isEmpty", "()Z", ref global::java.lang.String._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public char charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.lang.String.staticClass, "charAt", "(I)C", ref global::java.lang.String._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public int codePointAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "codePointAt", "(I)I", ref global::java.lang.String._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public int codePointBefore(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "codePointBefore", "(I)I", ref global::java.lang.String._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public int codePointCount(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "codePointCount", "(II)I", ref global::java.lang.String._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public int offsetByCodePoints(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "offsetByCodePoints", "(II)I", ref global::java.lang.String._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public void getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.String.staticClass, "getChars", "(II[CI)V", ref global::java.lang.String._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public void getBytes(int arg0, int arg1, byte[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.String.staticClass, "getBytes", "(II[BI)V", ref global::java.lang.String._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public byte[] getBytes(java.nio.charset.Charset arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.lang.String.staticClass, "getBytes", "(Ljava/nio/charset/Charset;)[B", ref global::java.lang.String._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		public new byte[] Bytes
		{
			get
			{
				return getBytes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public byte[] getBytes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.lang.String.staticClass, "getBytes", "()[B", ref global::java.lang.String._m19) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public byte[] getBytes(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.lang.String.staticClass, "getBytes", "(Ljava/lang/String;)[B", ref global::java.lang.String._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public bool contentEquals(java.lang.StringBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.String.staticClass, "contentEquals", "(Ljava/lang/StringBuffer;)Z", ref global::java.lang.String._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public bool contentEquals(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.String.staticClass, "contentEquals", "(Ljava/lang/CharSequence;)Z", ref global::java.lang.String._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool contentEquals(string arg0)
		{
			return contentEquals((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public bool equalsIgnoreCase(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.String.staticClass, "equalsIgnoreCase", "(Ljava/lang/String;)Z", ref global::java.lang.String._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public int compareToIgnoreCase(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "compareToIgnoreCase", "(Ljava/lang/String;)I", ref global::java.lang.String._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public bool regionMatches(bool arg0, int arg1, java.lang.String arg2, int arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.String.staticClass, "regionMatches", "(ZILjava/lang/String;II)Z", ref global::java.lang.String._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public bool regionMatches(int arg0, java.lang.String arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.String.staticClass, "regionMatches", "(ILjava/lang/String;II)Z", ref global::java.lang.String._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public bool startsWith(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.String.staticClass, "startsWith", "(Ljava/lang/String;)Z", ref global::java.lang.String._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public bool startsWith(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.String.staticClass, "startsWith", "(Ljava/lang/String;I)Z", ref global::java.lang.String._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public bool endsWith(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.String.staticClass, "endsWith", "(Ljava/lang/String;)Z", ref global::java.lang.String._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public int lastIndexOf(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I", ref global::java.lang.String._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public int lastIndexOf(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "lastIndexOf", "(II)I", ref global::java.lang.String._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public int lastIndexOf(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "lastIndexOf", "(I)I", ref global::java.lang.String._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public int lastIndexOf(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.String.staticClass, "lastIndexOf", "(Ljava/lang/String;)I", ref global::java.lang.String._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public global::java.lang.String substring(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "substring", "(I)Ljava/lang/String;", ref global::java.lang.String._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public global::java.lang.String substring(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "substring", "(II)Ljava/lang/String;", ref global::java.lang.String._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::java.lang.String.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::java.lang.String._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public global::java.lang.String concat(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "concat", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.lang.String._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public global::java.lang.String replace(char arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "replace", "(CC)Ljava/lang/String;", ref global::java.lang.String._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public global::java.lang.String replace(java.lang.CharSequence arg0, java.lang.CharSequence arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "replace", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;", ref global::java.lang.String._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		public java.lang.String replace(string arg0, string arg1)
		{
			return replace((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public bool matches(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.String.staticClass, "matches", "(Ljava/lang/String;)Z", ref global::java.lang.String._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public bool contains(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.String.staticClass, "contains", "(Ljava/lang/CharSequence;)Z", ref global::java.lang.String._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool contains(string arg0)
		{
			return contains((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public global::java.lang.String replaceFirst(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "replaceFirst", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::java.lang.String._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public global::java.lang.String replaceAll(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "replaceAll", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::java.lang.String._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public global::java.lang.String[] split(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "split", "(Ljava/lang/String;)[Ljava/lang/String;", ref global::java.lang.String._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public global::java.lang.String[] split(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "split", "(Ljava/lang/String;I)[Ljava/lang/String;", ref global::java.lang.String._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public global::java.lang.String toLowerCase()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "toLowerCase", "()Ljava/lang/String;", ref global::java.lang.String._m46) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public global::java.lang.String toLowerCase(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "toLowerCase", "(Ljava/util/Locale;)Ljava/lang/String;", ref global::java.lang.String._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public global::java.lang.String toUpperCase()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "toUpperCase", "()Ljava/lang/String;", ref global::java.lang.String._m48) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public global::java.lang.String toUpperCase(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "toUpperCase", "(Ljava/util/Locale;)Ljava/lang/String;", ref global::java.lang.String._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public global::java.lang.String trim()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "trim", "()Ljava/lang/String;", ref global::java.lang.String._m50) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public char[] toCharArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::java.lang.String.staticClass, "toCharArray", "()[C", ref global::java.lang.String._m51) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public static global::java.lang.String format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m52.native == global::System.IntPtr.Zero)
				global::java.lang.String._m52 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public static global::java.lang.String format(java.lang.String arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m53.native == global::System.IntPtr.Zero)
				global::java.lang.String._m53 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public static global::java.lang.String valueOf(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m54.native == global::System.IntPtr.Zero)
				global::java.lang.String._m54 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "([C)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public static global::java.lang.String valueOf(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m55.native == global::System.IntPtr.Zero)
				global::java.lang.String._m55 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(D)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public static global::java.lang.String valueOf(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m56.native == global::System.IntPtr.Zero)
				global::java.lang.String._m56 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(Ljava/lang/Object;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public static global::java.lang.String valueOf(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m57.native == global::System.IntPtr.Zero)
				global::java.lang.String._m57 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "([CII)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public static global::java.lang.String valueOf(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m58.native == global::System.IntPtr.Zero)
				global::java.lang.String._m58 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(Z)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public static global::java.lang.String valueOf(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m59.native == global::System.IntPtr.Zero)
				global::java.lang.String._m59 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(C)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public static global::java.lang.String valueOf(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m60.native == global::System.IntPtr.Zero)
				global::java.lang.String._m60 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public static global::java.lang.String valueOf(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m61.native == global::System.IntPtr.Zero)
				global::java.lang.String._m61 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(J)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public static global::java.lang.String valueOf(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m62.native == global::System.IntPtr.Zero)
				global::java.lang.String._m62 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "valueOf", "(F)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public static global::java.lang.String copyValueOf(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m63.native == global::System.IntPtr.Zero)
				global::java.lang.String._m63 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "copyValueOf", "([CII)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public static global::java.lang.String copyValueOf(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m64.native == global::System.IntPtr.Zero)
				global::java.lang.String._m64 = @__env.GetStaticMethodIDNoThrow(global::java.lang.String.staticClass, "copyValueOf", "([C)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.String.staticClass, global::java.lang.String._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public global::java.lang.String intern()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.String.staticClass, "intern", "()Ljava/lang/String;", ref global::java.lang.String._m65) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public String() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m66.native == global::System.IntPtr.Zero)
				global::java.lang.String._m66 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m66);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public String(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m67.native == global::System.IntPtr.Zero)
				global::java.lang.String._m67 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public String(char[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m68.native == global::System.IntPtr.Zero)
				global::java.lang.String._m68 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([C)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public String(char[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m69.native == global::System.IntPtr.Zero)
				global::java.lang.String._m69 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([CII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public String(int[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m70.native == global::System.IntPtr.Zero)
				global::java.lang.String._m70 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public String(byte[] arg0, int arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m71.native == global::System.IntPtr.Zero)
				global::java.lang.String._m71 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public String(byte[] arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m72.native == global::System.IntPtr.Zero)
				global::java.lang.String._m72 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BI)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public String(byte[] arg0, java.nio.charset.Charset arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m73.native == global::System.IntPtr.Zero)
				global::java.lang.String._m73 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BLjava/nio/charset/Charset;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public String(byte[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m74.native == global::System.IntPtr.Zero)
				global::java.lang.String._m74 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public String(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m75.native == global::System.IntPtr.Zero)
				global::java.lang.String._m75 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public String(java.lang.StringBuffer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m76.native == global::System.IntPtr.Zero)
				global::java.lang.String._m76 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "(Ljava/lang/StringBuffer;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public String(java.lang.StringBuilder arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m77.native == global::System.IntPtr.Zero)
				global::java.lang.String._m77 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "(Ljava/lang/StringBuilder;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public String(byte[] arg0, int arg1, int arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m78.native == global::System.IntPtr.Zero)
				global::java.lang.String._m78 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BIILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public String(byte[] arg0, int arg1, int arg2, java.nio.charset.Charset arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m79.native == global::System.IntPtr.Zero)
				global::java.lang.String._m79 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BIILjava/nio/charset/Charset;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public String(byte[] arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.String._m80.native == global::System.IntPtr.Zero)
				global::java.lang.String._m80 = @__env.GetMethodIDNoThrow(global::java.lang.String.staticClass, "<init>", "([BLjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.String.staticClass, global::java.lang.String._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CASE_INSENSITIVE_ORDER6398;
		public static global::java.util.Comparator CASE_INSENSITIVE_ORDER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.GetStaticObjectField(global::java.lang.String.staticClass, _CASE_INSENSITIVE_ORDER6398)) as java.util.Comparator;
			}
		}
		static String()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.String.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/String"));
			global::java.lang.String._CASE_INSENSITIVE_ORDER6398 = @__env.GetStaticFieldIDNoThrow(global::java.lang.String.staticClass, "CASE_INSENSITIVE_ORDER", "Ljava/util/Comparator;");
		}
	}
}
