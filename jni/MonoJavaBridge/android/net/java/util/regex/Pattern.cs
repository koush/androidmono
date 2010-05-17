namespace java.util.regex 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Pattern : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Pattern() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.regex.Pattern), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.util.regex.Pattern(@__env); 
			} 
		} 
		internal Pattern(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12138; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Pattern)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12138)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Pattern.staticClass, _toString12138)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _matches12139; 
		public static bool matches(java.lang.String arg0, java.lang.CharSequence arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(java.util.regex.Pattern.staticClass, _matches12139, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _split12140; 
		public java.lang.String[] split(java.lang.CharSequence arg0, int arg1) 
		{ 
			if (GetType() == typeof(java.util.regex.Pattern)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _split12140, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Pattern.staticClass, _split12140, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _split12141; 
		public java.lang.String[] split(java.lang.CharSequence arg0) 
		{ 
			if (GetType() == typeof(java.util.regex.Pattern)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _split12141, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Pattern.staticClass, _split12141, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compile12142; 
		public static java.util.regex.Pattern compile(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Pattern>(@__env, @__env.CallStaticObjectMethodPtr(java.util.regex.Pattern.staticClass, _compile12142, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compile12143; 
		public static java.util.regex.Pattern compile(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Pattern>(@__env, @__env.CallStaticObjectMethodPtr(java.util.regex.Pattern.staticClass, _compile12143, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _matcher12144; 
		public java.util.regex.Matcher matcher(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Pattern)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, _matcher12144, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Pattern.staticClass, _matcher12144, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quote12145; 
		public static java.lang.String quote(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(java.util.regex.Pattern.staticClass, _quote12145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pattern12146; 
		public java.lang.String pattern() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Pattern)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _pattern12146)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Pattern.staticClass, _pattern12146)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flags12147; 
		public int flags() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Pattern)) 
				return @__env.CallIntMethod(this, _flags12147); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.regex.Pattern.staticClass, _flags12147); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.regex.Pattern.staticClass = @__class; 
			global::java.util.regex.Pattern._toString12138 = @__env.GetMethodID(global::java.util.regex.Pattern.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.regex.Pattern._matches12139 = @__env.GetStaticMethodID(global::java.util.regex.Pattern.staticClass, "matches", "(Ljava/lang/String;Ljava/lang/CharSequence;)Z"); 
			global::java.util.regex.Pattern._split12140 = @__env.GetMethodID(global::java.util.regex.Pattern.staticClass, "split", "(Ljava/lang/CharSequence;I)[Ljava/lang/String;"); 
			global::java.util.regex.Pattern._split12141 = @__env.GetMethodID(global::java.util.regex.Pattern.staticClass, "split", "(Ljava/lang/CharSequence;)[Ljava/lang/String;"); 
			global::java.util.regex.Pattern._compile12142 = @__env.GetStaticMethodID(global::java.util.regex.Pattern.staticClass, "compile", "(Ljava/lang/String;)Ljava/util/regex/Pattern;"); 
			global::java.util.regex.Pattern._compile12143 = @__env.GetStaticMethodID(global::java.util.regex.Pattern.staticClass, "compile", "(Ljava/lang/String;I)Ljava/util/regex/Pattern;"); 
			global::java.util.regex.Pattern._matcher12144 = @__env.GetMethodID(global::java.util.regex.Pattern.staticClass, "matcher", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;"); 
			global::java.util.regex.Pattern._quote12145 = @__env.GetStaticMethodID(global::java.util.regex.Pattern.staticClass, "quote", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.util.regex.Pattern._pattern12146 = @__env.GetMethodID(global::java.util.regex.Pattern.staticClass, "pattern", "()Ljava/lang/String;"); 
			global::java.util.regex.Pattern._flags12147 = @__env.GetMethodID(global::java.util.regex.Pattern.staticClass, "flags", "()I"); 
		} 
	} 
} 
