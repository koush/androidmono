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
		internal static global::net.sf.jni4net.jni.MethodId _group13891;
		public global::java.lang.String group() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._group13891));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._group13891));
		}
		internal static global::net.sf.jni4net.jni.MethodId _group13892;
		public global::java.lang.String group(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._group13892, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._group13892, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13893;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._toString13893));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._toString13893));
		}
		internal static global::net.sf.jni4net.jni.MethodId _matches13894;
		public bool matches() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._matches13894);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._matches13894);
		}
		internal static global::net.sf.jni4net.jni.MethodId _replaceFirst13895;
		public global::java.lang.String replaceFirst(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._replaceFirst13895, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._replaceFirst13895, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _replaceAll13896;
		public global::java.lang.String replaceAll(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._replaceAll13896, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._replaceAll13896, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quoteReplacement13897;
		public static global::java.lang.String quoteReplacement(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._quoteReplacement13897, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _find13898;
		public bool find() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._find13898);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._find13898);
		}
		internal static global::net.sf.jni4net.jni.MethodId _find13899;
		public bool find(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._find13899, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._find13899, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _start13900;
		public int start(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.regex.Matcher._start13900, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._start13900, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _start13901;
		public int start() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.regex.Matcher._start13901);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._start13901);
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset13902;
		public global::java.util.regex.Matcher reset(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._reset13902, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._reset13902, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		public java.util.regex.Matcher reset(string arg0)
		{
			return reset((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset13903;
		public global::java.util.regex.Matcher reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._reset13903));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._reset13903));
		}
		internal static global::net.sf.jni4net.jni.MethodId _appendReplacement13904;
		public global::java.util.regex.Matcher appendReplacement(java.lang.StringBuffer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._appendReplacement13904, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._appendReplacement13904, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _appendTail13905;
		public global::java.lang.StringBuffer appendTail(java.lang.StringBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._appendTail13905, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._appendTail13905, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _end13906;
		public int end(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.regex.Matcher._end13906, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._end13906, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _end13907;
		public int end() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.regex.Matcher._end13907);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._end13907);
		}
		internal static global::net.sf.jni4net.jni.MethodId _pattern13908;
		public global::java.util.regex.Pattern pattern() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Pattern>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._pattern13908));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Pattern>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._pattern13908));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hitEnd13909;
		public bool hitEnd() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._hitEnd13909);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hitEnd13909);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requireEnd13910;
		public bool requireEnd() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._requireEnd13910);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._requireEnd13910);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toMatchResult13911;
		public global::java.util.regex.MatchResult toMatchResult() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.regex.MatchResult>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._toMatchResult13911));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.regex.MatchResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._toMatchResult13911));
		}
		internal static global::net.sf.jni4net.jni.MethodId _usePattern13912;
		public global::java.util.regex.Matcher usePattern(java.util.regex.Pattern arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._usePattern13912, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._usePattern13912, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _groupCount13913;
		public int groupCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.regex.Matcher._groupCount13913);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._groupCount13913);
		}
		internal static global::net.sf.jni4net.jni.MethodId _lookingAt13914;
		public bool lookingAt() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._lookingAt13914);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._lookingAt13914);
		}
		internal static global::net.sf.jni4net.jni.MethodId _region13915;
		public global::java.util.regex.Matcher region(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._region13915, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._region13915, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _regionStart13916;
		public int regionStart() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.regex.Matcher._regionStart13916);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._regionStart13916);
		}
		internal static global::net.sf.jni4net.jni.MethodId _regionEnd13917;
		public int regionEnd() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.regex.Matcher._regionEnd13917);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._regionEnd13917);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasTransparentBounds13918;
		public bool hasTransparentBounds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._hasTransparentBounds13918);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hasTransparentBounds13918);
		}
		internal static global::net.sf.jni4net.jni.MethodId _useTransparentBounds13919;
		public global::java.util.regex.Matcher useTransparentBounds(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._useTransparentBounds13919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._useTransparentBounds13919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasAnchoringBounds13920;
		public bool hasAnchoringBounds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.regex.Matcher._hasAnchoringBounds13920);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hasAnchoringBounds13920);
		}
		internal static global::net.sf.jni4net.jni.MethodId _useAnchoringBounds13921;
		public global::java.util.regex.Matcher useAnchoringBounds(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Matcher._useAnchoringBounds13921, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._useAnchoringBounds13921, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.regex.Matcher.staticClass = @__class;
			global::java.util.regex.Matcher._group13891 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "group", "()Ljava/lang/String;");
			global::java.util.regex.Matcher._group13892 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "group", "(I)Ljava/lang/String;");
			global::java.util.regex.Matcher._toString13893 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.regex.Matcher._matches13894 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "matches", "()Z");
			global::java.util.regex.Matcher._replaceFirst13895 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "replaceFirst", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.regex.Matcher._replaceAll13896 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "replaceAll", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.regex.Matcher._quoteReplacement13897 = @__env.GetStaticMethodID(global::java.util.regex.Matcher.staticClass, "quoteReplacement", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.regex.Matcher._find13898 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "find", "()Z");
			global::java.util.regex.Matcher._find13899 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "find", "(I)Z");
			global::java.util.regex.Matcher._start13900 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "start", "(I)I");
			global::java.util.regex.Matcher._start13901 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "start", "()I");
			global::java.util.regex.Matcher._reset13902 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "reset", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._reset13903 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "reset", "()Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._appendReplacement13904 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "appendReplacement", "(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._appendTail13905 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "appendTail", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
			global::java.util.regex.Matcher._end13906 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "end", "(I)I");
			global::java.util.regex.Matcher._end13907 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "end", "()I");
			global::java.util.regex.Matcher._pattern13908 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "pattern", "()Ljava/util/regex/Pattern;");
			global::java.util.regex.Matcher._hitEnd13909 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "hitEnd", "()Z");
			global::java.util.regex.Matcher._requireEnd13910 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "requireEnd", "()Z");
			global::java.util.regex.Matcher._toMatchResult13911 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "toMatchResult", "()Ljava/util/regex/MatchResult;");
			global::java.util.regex.Matcher._usePattern13912 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "usePattern", "(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._groupCount13913 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "groupCount", "()I");
			global::java.util.regex.Matcher._lookingAt13914 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "lookingAt", "()Z");
			global::java.util.regex.Matcher._region13915 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "region", "(II)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._regionStart13916 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "regionStart", "()I");
			global::java.util.regex.Matcher._regionEnd13917 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "regionEnd", "()I");
			global::java.util.regex.Matcher._hasTransparentBounds13918 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "hasTransparentBounds", "()Z");
			global::java.util.regex.Matcher._useTransparentBounds13919 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "useTransparentBounds", "(Z)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._hasAnchoringBounds13920 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "hasAnchoringBounds", "()Z");
			global::java.util.regex.Matcher._useAnchoringBounds13921 = @__env.GetMethodID(global::java.util.regex.Matcher.staticClass, "useAnchoringBounds", "(Z)Ljava/util/regex/Matcher;");
		}
	}
}
