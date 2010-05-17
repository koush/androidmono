namespace java.util.regex 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Matcher : java.lang.Object, MatchResult
	{ 
		internal static global::java.lang.Class staticClass; 
		static Matcher() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.regex.Matcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.util.regex.Matcher(@__env); 
			} 
		} 
		internal Matcher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _group12107; 
		public java.lang.String group() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _group12107)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _group12107)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _group12108; 
		public java.lang.String group(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _group12108, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _group12108, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12109; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12109)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _toString12109)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _matches12110; 
		public bool matches() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, _matches12110); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.regex.Matcher.staticClass, _matches12110); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replaceFirst12111; 
		public java.lang.String replaceFirst(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _replaceFirst12111, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _replaceFirst12111, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replaceAll12112; 
		public java.lang.String replaceAll(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _replaceAll12112, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _replaceAll12112, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quoteReplacement12113; 
		public static java.lang.String quoteReplacement(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(java.util.regex.Matcher.staticClass, _quoteReplacement12113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _find12114; 
		public bool find() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, _find12114); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.regex.Matcher.staticClass, _find12114); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _find12115; 
		public bool find(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, _find12115, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.regex.Matcher.staticClass, _find12115, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start12116; 
		public int start(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallIntMethod(this, _start12116, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.regex.Matcher.staticClass, _start12116, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start12117; 
		public int start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallIntMethod(this, _start12117); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.regex.Matcher.staticClass, _start12117); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset12118; 
		public java.util.regex.Matcher reset(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, _reset12118, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _reset12118, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset12119; 
		public java.util.regex.Matcher reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, _reset12119)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _reset12119)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _appendReplacement12120; 
		public java.util.regex.Matcher appendReplacement(java.lang.StringBuffer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, _appendReplacement12120, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _appendReplacement12120, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _appendTail12121; 
		public java.lang.StringBuffer appendTail(java.lang.StringBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallObjectMethodPtr(this, _appendTail12121, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _appendTail12121, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _end12122; 
		public int end(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallIntMethod(this, _end12122, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.regex.Matcher.staticClass, _end12122, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _end12123; 
		public int end() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallIntMethod(this, _end12123); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.regex.Matcher.staticClass, _end12123); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pattern12124; 
		public java.util.regex.Pattern pattern() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Pattern>(@__env, @__env.CallObjectMethodPtr(this, _pattern12124)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Pattern>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _pattern12124)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hitEnd12125; 
		public bool hitEnd() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, _hitEnd12125); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.regex.Matcher.staticClass, _hitEnd12125); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requireEnd12126; 
		public bool requireEnd() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, _requireEnd12126); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.regex.Matcher.staticClass, _requireEnd12126); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toMatchResult12127; 
		public java.util.regex.MatchResult toMatchResult() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.regex.MatchResult>(@__env, @__env.CallObjectMethodPtr(this, _toMatchResult12127)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.regex.MatchResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _toMatchResult12127)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _usePattern12128; 
		public java.util.regex.Matcher usePattern(java.util.regex.Pattern arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, _usePattern12128, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _usePattern12128, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _groupCount12129; 
		public int groupCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallIntMethod(this, _groupCount12129); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.regex.Matcher.staticClass, _groupCount12129); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lookingAt12130; 
		public bool lookingAt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, _lookingAt12130); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.regex.Matcher.staticClass, _lookingAt12130); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _region12131; 
		public java.util.regex.Matcher region(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, _region12131, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _region12131, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _regionStart12132; 
		public int regionStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallIntMethod(this, _regionStart12132); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.regex.Matcher.staticClass, _regionStart12132); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _regionEnd12133; 
		public int regionEnd() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallIntMethod(this, _regionEnd12133); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.regex.Matcher.staticClass, _regionEnd12133); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasTransparentBounds12134; 
		public bool hasTransparentBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, _hasTransparentBounds12134); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.regex.Matcher.staticClass, _hasTransparentBounds12134); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _useTransparentBounds12135; 
		public java.util.regex.Matcher useTransparentBounds(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, _useTransparentBounds12135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _useTransparentBounds12135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAnchoringBounds12136; 
		public bool hasAnchoringBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, _hasAnchoringBounds12136); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.regex.Matcher.staticClass, _hasAnchoringBounds12136); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _useAnchoringBounds12137; 
		public java.util.regex.Matcher useAnchoringBounds(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, _useAnchoringBounds12137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.Matcher.staticClass, _useAnchoringBounds12137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.regex.Matcher.staticClass = @__class; 
			global::java.util.regex.Matcher._group12107 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "group", "()Ljava/lang/String;"); 
			global::java.util.regex.Matcher._group12108 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "group", "(I)Ljava/lang/String;"); 
			global::java.util.regex.Matcher._toString12109 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.regex.Matcher._matches12110 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "matches", "()Z"); 
			global::java.util.regex.Matcher._replaceFirst12111 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "replaceFirst", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.util.regex.Matcher._replaceAll12112 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "replaceAll", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.util.regex.Matcher._quoteReplacement12113 = @__env.GetStaticMethodID(global::java.util.regex.Matcher.staticClass, "quoteReplacement", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.util.regex.Matcher._find12114 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "find", "()Z"); 
			global::java.util.regex.Matcher._find12115 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "find", "(I)Z"); 
			global::java.util.regex.Matcher._start12116 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "start", "(I)I"); 
			global::java.util.regex.Matcher._start12117 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "start", "()I"); 
			global::java.util.regex.Matcher._reset12118 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "reset", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;"); 
			global::java.util.regex.Matcher._reset12119 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "reset", "()Ljava/util/regex/Matcher;"); 
			global::java.util.regex.Matcher._appendReplacement12120 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "appendReplacement", "(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;"); 
			global::java.util.regex.Matcher._appendTail12121 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "appendTail", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;"); 
			global::java.util.regex.Matcher._end12122 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "end", "(I)I"); 
			global::java.util.regex.Matcher._end12123 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "end", "()I"); 
			global::java.util.regex.Matcher._pattern12124 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "pattern", "()Ljava/util/regex/Pattern;"); 
			global::java.util.regex.Matcher._hitEnd12125 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "hitEnd", "()Z"); 
			global::java.util.regex.Matcher._requireEnd12126 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "requireEnd", "()Z"); 
			global::java.util.regex.Matcher._toMatchResult12127 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "toMatchResult", "()Ljava/util/regex/MatchResult;"); 
			global::java.util.regex.Matcher._usePattern12128 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "usePattern", "(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;"); 
			global::java.util.regex.Matcher._groupCount12129 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "groupCount", "()I"); 
			global::java.util.regex.Matcher._lookingAt12130 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "lookingAt", "()Z"); 
			global::java.util.regex.Matcher._region12131 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "region", "(II)Ljava/util/regex/Matcher;"); 
			global::java.util.regex.Matcher._regionStart12132 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "regionStart", "()I"); 
			global::java.util.regex.Matcher._regionEnd12133 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "regionEnd", "()I"); 
			global::java.util.regex.Matcher._hasTransparentBounds12134 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "hasTransparentBounds", "()Z"); 
			global::java.util.regex.Matcher._useTransparentBounds12135 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "useTransparentBounds", "(Z)Ljava/util/regex/Matcher;"); 
			global::java.util.regex.Matcher._hasAnchoringBounds12136 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "hasAnchoringBounds", "()Z"); 
			global::java.util.regex.Matcher._useAnchoringBounds12137 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "useAnchoringBounds", "(Z)Ljava/util/regex/Matcher;"); 
		} 
	} 
} 
