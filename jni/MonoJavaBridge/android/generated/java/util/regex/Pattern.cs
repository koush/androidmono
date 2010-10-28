namespace java.util.regex
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Pattern : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Pattern(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString28304;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Pattern._toString28304)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._toString28304)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _flags28305;
		public int flags()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Pattern._flags28305);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._flags28305);
		}
		internal static global::MonoJavaBridge.MethodId _matches28306;
		public static bool matches(java.lang.String arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._matches28306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static bool matches(java.lang.String arg0, string arg1)
		{
			return matches(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _split28307;
		public global::java.lang.String[] split(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Pattern._split28307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._split28307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		public java.lang.String[] split(string arg0)
		{
			return split((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _split28308;
		public global::java.lang.String[] split(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Pattern._split28308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._split28308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		public java.lang.String[] split(string arg0, int arg1)
		{
			return split((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _compile28309;
		public static global::java.util.regex.Pattern compile(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Pattern>(@__env.CallStaticObjectMethod(java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._compile28309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.Pattern;
		}
		internal static global::MonoJavaBridge.MethodId _compile28310;
		public static global::java.util.regex.Pattern compile(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Pattern>(@__env.CallStaticObjectMethod(java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._compile28310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Pattern;
		}
		internal static global::MonoJavaBridge.MethodId _matcher28311;
		public global::java.util.regex.Matcher matcher(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Pattern._matcher28311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._matcher28311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
		}
		public java.util.regex.Matcher matcher(string arg0)
		{
			return matcher((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _quote28312;
		public static global::java.lang.String quote(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._quote28312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _pattern28313;
		public global::java.lang.String pattern()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Pattern._pattern28313)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._pattern28313)) as java.lang.String;
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
			global::java.util.regex.Pattern._toString28304 = @__env.GetMethodIDNoThrow(global::java.util.regex.Pattern.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.regex.Pattern._flags28305 = @__env.GetMethodIDNoThrow(global::java.util.regex.Pattern.staticClass, "flags", "()I");
			global::java.util.regex.Pattern._matches28306 = @__env.GetStaticMethodIDNoThrow(global::java.util.regex.Pattern.staticClass, "matches", "(Ljava/lang/String;Ljava/lang/CharSequence;)Z");
			global::java.util.regex.Pattern._split28307 = @__env.GetMethodIDNoThrow(global::java.util.regex.Pattern.staticClass, "split", "(Ljava/lang/CharSequence;)[Ljava/lang/String;");
			global::java.util.regex.Pattern._split28308 = @__env.GetMethodIDNoThrow(global::java.util.regex.Pattern.staticClass, "split", "(Ljava/lang/CharSequence;I)[Ljava/lang/String;");
			global::java.util.regex.Pattern._compile28309 = @__env.GetStaticMethodIDNoThrow(global::java.util.regex.Pattern.staticClass, "compile", "(Ljava/lang/String;I)Ljava/util/regex/Pattern;");
			global::java.util.regex.Pattern._compile28310 = @__env.GetStaticMethodIDNoThrow(global::java.util.regex.Pattern.staticClass, "compile", "(Ljava/lang/String;)Ljava/util/regex/Pattern;");
			global::java.util.regex.Pattern._matcher28311 = @__env.GetMethodIDNoThrow(global::java.util.regex.Pattern.staticClass, "matcher", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;");
			global::java.util.regex.Pattern._quote28312 = @__env.GetStaticMethodIDNoThrow(global::java.util.regex.Pattern.staticClass, "quote", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.regex.Pattern._pattern28313 = @__env.GetMethodIDNoThrow(global::java.util.regex.Pattern.staticClass, "pattern", "()Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
