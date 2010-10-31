namespace java.util.regex
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Pattern : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Pattern(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.Pattern.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.regex.Pattern._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public int flags()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Pattern.staticClass, "flags", "()I", ref global::java.util.regex.Pattern._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static bool matches(java.lang.String arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.regex.Pattern._m2.native == global::System.IntPtr.Zero)
				global::java.util.regex.Pattern._m2 = @__env.GetStaticMethodIDNoThrow(global::java.util.regex.Pattern.staticClass, "matches", "(Ljava/lang/String;Ljava/lang/CharSequence;)Z");
			return @__env.CallStaticBooleanMethod(java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static bool matches(java.lang.String arg0, string arg1)
		{
			return matches(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.String[] split(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.util.regex.Pattern.staticClass, "split", "(Ljava/lang/CharSequence;)[Ljava/lang/String;", ref global::java.util.regex.Pattern._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		public java.lang.String[] split(string arg0)
		{
			return split((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.lang.String[] split(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.util.regex.Pattern.staticClass, "split", "(Ljava/lang/CharSequence;I)[Ljava/lang/String;", ref global::java.util.regex.Pattern._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String[];
		}
		public java.lang.String[] split(string arg0, int arg1)
		{
			return split((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.util.regex.Pattern compile(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.regex.Pattern._m5.native == global::System.IntPtr.Zero)
				global::java.util.regex.Pattern._m5 = @__env.GetStaticMethodIDNoThrow(global::java.util.regex.Pattern.staticClass, "compile", "(Ljava/lang/String;I)Ljava/util/regex/Pattern;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Pattern>(@__env.CallStaticObjectMethod(java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.Pattern;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.util.regex.Pattern compile(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.regex.Pattern._m6.native == global::System.IntPtr.Zero)
				global::java.util.regex.Pattern._m6 = @__env.GetStaticMethodIDNoThrow(global::java.util.regex.Pattern.staticClass, "compile", "(Ljava/lang/String;)Ljava/util/regex/Pattern;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Pattern>(@__env.CallStaticObjectMethod(java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Pattern;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.util.regex.Matcher matcher(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Pattern.staticClass, "matcher", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;", ref global::java.util.regex.Pattern._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.regex.Matcher;
		}
		public java.util.regex.Matcher matcher(string arg0)
		{
			return matcher((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.lang.String quote(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.regex.Pattern._m8.native == global::System.IntPtr.Zero)
				global::java.util.regex.Pattern._m8 = @__env.GetStaticMethodIDNoThrow(global::java.util.regex.Pattern.staticClass, "quote", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::java.lang.String pattern()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.Pattern.staticClass, "pattern", "()Ljava/lang/String;", ref global::java.util.regex.Pattern._m9) as java.lang.String;
		}
		public static int UNIX_LINES
		{
			get
			{
				return 1;
			}
		}
		public static int CASE_INSENSITIVE
		{
			get
			{
				return 2;
			}
		}
		public static int COMMENTS
		{
			get
			{
				return 4;
			}
		}
		public static int MULTILINE
		{
			get
			{
				return 8;
			}
		}
		public static int LITERAL
		{
			get
			{
				return 16;
			}
		}
		public static int DOTALL
		{
			get
			{
				return 32;
			}
		}
		public static int UNICODE_CASE
		{
			get
			{
				return 64;
			}
		}
		public static int CANON_EQ
		{
			get
			{
				return 128;
			}
		}
		static Pattern()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.regex.Pattern.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/regex/Pattern"));
		}
	}
}
