namespace java.util.regex 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Matcher : java.lang.Object, MatchResult
	{ 
		internal static global::java.lang.Class staticClass; 
		static Matcher() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.regex.Matcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _group13060; 
		public global::java.lang.String group() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._group13060)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._group13060)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _group13061; 
		public global::java.lang.String group(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._group13061, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._group13061, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString13062; 
		public sealed override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._toString13062)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._toString13062)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _matches13063; 
		public bool matches() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._matches13063); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._matches13063); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replaceFirst13064; 
		public global::java.lang.String replaceFirst(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._replaceFirst13064, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._replaceFirst13064, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replaceAll13065; 
		public global::java.lang.String replaceAll(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._replaceAll13065, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._replaceAll13065, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quoteReplacement13066; 
		public static global::java.lang.String quoteReplacement(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._quoteReplacement13066, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _find13067; 
		public bool find() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._find13067); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._find13067); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _find13068; 
		public bool find(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._find13068, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._find13068, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start13069; 
		public int start(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallIntMethod(this, global::java.util.regex.Matcher._start13069, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._start13069, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start13070; 
		public int start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallIntMethod(this, global::java.util.regex.Matcher._start13070); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._start13070); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset13071; 
		public global::java.util.regex.Matcher reset(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._reset13071, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._reset13071, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset13072; 
		public global::java.util.regex.Matcher reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._reset13072)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._reset13072)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _appendReplacement13073; 
		public global::java.util.regex.Matcher appendReplacement(java.lang.StringBuffer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._appendReplacement13073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._appendReplacement13073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _appendTail13074; 
		public global::java.lang.StringBuffer appendTail(java.lang.StringBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._appendTail13074, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._appendTail13074, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _end13075; 
		public int end(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallIntMethod(this, global::java.util.regex.Matcher._end13075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._end13075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _end13076; 
		public int end() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallIntMethod(this, global::java.util.regex.Matcher._end13076); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._end13076); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pattern13077; 
		public global::java.util.regex.Pattern pattern() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Pattern>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._pattern13077)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Pattern>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._pattern13077)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hitEnd13078; 
		public bool hitEnd() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._hitEnd13078); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hitEnd13078); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requireEnd13079; 
		public bool requireEnd() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._requireEnd13079); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._requireEnd13079); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toMatchResult13080; 
		public global::java.util.regex.MatchResult toMatchResult() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.regex.MatchResult>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._toMatchResult13080)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.regex.MatchResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._toMatchResult13080)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _usePattern13081; 
		public global::java.util.regex.Matcher usePattern(java.util.regex.Pattern arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._usePattern13081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._usePattern13081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _groupCount13082; 
		public int groupCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallIntMethod(this, global::java.util.regex.Matcher._groupCount13082); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._groupCount13082); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lookingAt13083; 
		public bool lookingAt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._lookingAt13083); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._lookingAt13083); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _region13084; 
		public global::java.util.regex.Matcher region(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._region13084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._region13084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _regionStart13085; 
		public int regionStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallIntMethod(this, global::java.util.regex.Matcher._regionStart13085); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._regionStart13085); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _regionEnd13086; 
		public int regionEnd() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallIntMethod(this, global::java.util.regex.Matcher._regionEnd13086); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._regionEnd13086); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasTransparentBounds13087; 
		public bool hasTransparentBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._hasTransparentBounds13087); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hasTransparentBounds13087); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _useTransparentBounds13088; 
		public global::java.util.regex.Matcher useTransparentBounds(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._useTransparentBounds13088, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._useTransparentBounds13088, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAnchoringBounds13089; 
		public bool hasAnchoringBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._hasAnchoringBounds13089); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hasAnchoringBounds13089); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _useAnchoringBounds13090; 
		public global::java.util.regex.Matcher useAnchoringBounds(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.Matcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._useAnchoringBounds13090, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._useAnchoringBounds13090, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.regex.Matcher.staticClass = @__class; 
			global::java.util.regex.Matcher._group13060 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "group", "()Ljava/lang/String;"); 
			global::java.util.regex.Matcher._group13061 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "group", "(I)Ljava/lang/String;"); 
			global::java.util.regex.Matcher._toString13062 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.regex.Matcher._matches13063 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "matches", "()Z"); 
			global::java.util.regex.Matcher._replaceFirst13064 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "replaceFirst", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.util.regex.Matcher._replaceAll13065 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "replaceAll", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.util.regex.Matcher._quoteReplacement13066 = @__env.GetStaticMethodID(global::java.util.regex.Matcher.staticClass, "quoteReplacement", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.util.regex.Matcher._find13067 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "find", "()Z"); 
			global::java.util.regex.Matcher._find13068 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "find", "(I)Z"); 
			global::java.util.regex.Matcher._start13069 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "start", "(I)I"); 
			global::java.util.regex.Matcher._start13070 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "start", "()I"); 
			global::java.util.regex.Matcher._reset13071 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "reset", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;"); 
			global::java.util.regex.Matcher._reset13072 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "reset", "()Ljava/util/regex/Matcher;"); 
			global::java.util.regex.Matcher._appendReplacement13073 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "appendReplacement", "(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;"); 
			global::java.util.regex.Matcher._appendTail13074 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "appendTail", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;"); 
			global::java.util.regex.Matcher._end13075 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "end", "(I)I"); 
			global::java.util.regex.Matcher._end13076 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "end", "()I"); 
			global::java.util.regex.Matcher._pattern13077 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "pattern", "()Ljava/util/regex/Pattern;"); 
			global::java.util.regex.Matcher._hitEnd13078 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "hitEnd", "()Z"); 
			global::java.util.regex.Matcher._requireEnd13079 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "requireEnd", "()Z"); 
			global::java.util.regex.Matcher._toMatchResult13080 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "toMatchResult", "()Ljava/util/regex/MatchResult;"); 
			global::java.util.regex.Matcher._usePattern13081 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "usePattern", "(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;"); 
			global::java.util.regex.Matcher._groupCount13082 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "groupCount", "()I"); 
			global::java.util.regex.Matcher._lookingAt13083 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "lookingAt", "()Z"); 
			global::java.util.regex.Matcher._region13084 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "region", "(II)Ljava/util/regex/Matcher;"); 
			global::java.util.regex.Matcher._regionStart13085 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "regionStart", "()I"); 
			global::java.util.regex.Matcher._regionEnd13086 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "regionEnd", "()I"); 
			global::java.util.regex.Matcher._hasTransparentBounds13087 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "hasTransparentBounds", "()Z"); 
			global::java.util.regex.Matcher._useTransparentBounds13088 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "useTransparentBounds", "(Z)Ljava/util/regex/Matcher;"); 
			global::java.util.regex.Matcher._hasAnchoringBounds13089 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "hasAnchoringBounds", "()Z"); 
			global::java.util.regex.Matcher._useAnchoringBounds13090 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "useAnchoringBounds", "(Z)Ljava/util/regex/Matcher;"); 
		} 
	} 
} 
