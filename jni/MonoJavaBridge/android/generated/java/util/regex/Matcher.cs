namespace java.util.regex
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Matcher : java.lang.Object, MatchResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Matcher()
		{
			InitJNI();
		}
		internal Matcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _group22288;
		public global::java.lang.String group() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._group22288)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._group22288)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _group22289;
		public global::java.lang.String group(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._group22289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._group22289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString22290;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._toString22290)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._toString22290)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _matches22291;
		public bool matches() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._matches22291);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._matches22291);
		}
		internal static global::MonoJavaBridge.MethodId _replaceFirst22292;
		public global::java.lang.String replaceFirst(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._replaceFirst22292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._replaceFirst22292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _replaceAll22293;
		public global::java.lang.String replaceAll(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._replaceAll22293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._replaceAll22293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _quoteReplacement22294;
		public static global::java.lang.String quoteReplacement(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._quoteReplacement22294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _find22295;
		public bool find() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._find22295);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._find22295);
		}
		internal static global::MonoJavaBridge.MethodId _find22296;
		public bool find(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._find22296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._find22296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _start22297;
		public int start(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._start22297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._start22297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _start22298;
		public int start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._start22298);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._start22298);
		}
		internal static global::MonoJavaBridge.MethodId _reset22299;
		public global::java.util.regex.Matcher reset(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._reset22299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._reset22299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
		}
		public java.util.regex.Matcher reset(string arg0)
		{
			return reset((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _reset22300;
		public global::java.util.regex.Matcher reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._reset22300)) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._reset22300)) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _appendReplacement22301;
		public global::java.util.regex.Matcher appendReplacement(java.lang.StringBuffer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._appendReplacement22301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._appendReplacement22301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _appendTail22302;
		public global::java.lang.StringBuffer appendTail(java.lang.StringBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._appendTail22302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._appendTail22302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _end22303;
		public int end(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._end22303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._end22303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _end22304;
		public int end() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._end22304);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._end22304);
		}
		internal static global::MonoJavaBridge.MethodId _pattern22305;
		public global::java.util.regex.Pattern pattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._pattern22305)) as java.util.regex.Pattern;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._pattern22305)) as java.util.regex.Pattern;
		}
		internal static global::MonoJavaBridge.MethodId _hitEnd22306;
		public bool hitEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._hitEnd22306);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hitEnd22306);
		}
		internal static global::MonoJavaBridge.MethodId _requireEnd22307;
		public bool requireEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._requireEnd22307);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._requireEnd22307);
		}
		internal static global::MonoJavaBridge.MethodId _toMatchResult22308;
		public global::java.util.regex.MatchResult toMatchResult() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._toMatchResult22308)) as java.util.regex.MatchResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._toMatchResult22308)) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _usePattern22309;
		public global::java.util.regex.Matcher usePattern(java.util.regex.Pattern arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._usePattern22309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._usePattern22309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _groupCount22310;
		public int groupCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._groupCount22310);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._groupCount22310);
		}
		internal static global::MonoJavaBridge.MethodId _lookingAt22311;
		public bool lookingAt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._lookingAt22311);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._lookingAt22311);
		}
		internal static global::MonoJavaBridge.MethodId _region22312;
		public global::java.util.regex.Matcher region(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._region22312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._region22312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _regionStart22313;
		public int regionStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._regionStart22313);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._regionStart22313);
		}
		internal static global::MonoJavaBridge.MethodId _regionEnd22314;
		public int regionEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._regionEnd22314);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._regionEnd22314);
		}
		internal static global::MonoJavaBridge.MethodId _hasTransparentBounds22315;
		public bool hasTransparentBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._hasTransparentBounds22315);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hasTransparentBounds22315);
		}
		internal static global::MonoJavaBridge.MethodId _useTransparentBounds22316;
		public global::java.util.regex.Matcher useTransparentBounds(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._useTransparentBounds22316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._useTransparentBounds22316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _hasAnchoringBounds22317;
		public bool hasAnchoringBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._hasAnchoringBounds22317);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hasAnchoringBounds22317);
		}
		internal static global::MonoJavaBridge.MethodId _useAnchoringBounds22318;
		public global::java.util.regex.Matcher useAnchoringBounds(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._useAnchoringBounds22318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._useAnchoringBounds22318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.regex.Matcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/regex/Matcher"));
			global::java.util.regex.Matcher._group22288 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "group", "()Ljava/lang/String;");
			global::java.util.regex.Matcher._group22289 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "group", "(I)Ljava/lang/String;");
			global::java.util.regex.Matcher._toString22290 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.regex.Matcher._matches22291 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "matches", "()Z");
			global::java.util.regex.Matcher._replaceFirst22292 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "replaceFirst", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.regex.Matcher._replaceAll22293 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "replaceAll", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.regex.Matcher._quoteReplacement22294 = @__env.GetStaticMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "quoteReplacement", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.regex.Matcher._find22295 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "find", "()Z");
			global::java.util.regex.Matcher._find22296 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "find", "(I)Z");
			global::java.util.regex.Matcher._start22297 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "start", "(I)I");
			global::java.util.regex.Matcher._start22298 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "start", "()I");
			global::java.util.regex.Matcher._reset22299 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "reset", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._reset22300 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "reset", "()Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._appendReplacement22301 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "appendReplacement", "(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._appendTail22302 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "appendTail", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
			global::java.util.regex.Matcher._end22303 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "end", "(I)I");
			global::java.util.regex.Matcher._end22304 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "end", "()I");
			global::java.util.regex.Matcher._pattern22305 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "pattern", "()Ljava/util/regex/Pattern;");
			global::java.util.regex.Matcher._hitEnd22306 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "hitEnd", "()Z");
			global::java.util.regex.Matcher._requireEnd22307 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "requireEnd", "()Z");
			global::java.util.regex.Matcher._toMatchResult22308 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "toMatchResult", "()Ljava/util/regex/MatchResult;");
			global::java.util.regex.Matcher._usePattern22309 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "usePattern", "(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._groupCount22310 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "groupCount", "()I");
			global::java.util.regex.Matcher._lookingAt22311 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "lookingAt", "()Z");
			global::java.util.regex.Matcher._region22312 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "region", "(II)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._regionStart22313 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "regionStart", "()I");
			global::java.util.regex.Matcher._regionEnd22314 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "regionEnd", "()I");
			global::java.util.regex.Matcher._hasTransparentBounds22315 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "hasTransparentBounds", "()Z");
			global::java.util.regex.Matcher._useTransparentBounds22316 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "useTransparentBounds", "(Z)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._hasAnchoringBounds22317 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "hasAnchoringBounds", "()Z");
			global::java.util.regex.Matcher._useAnchoringBounds22318 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "useAnchoringBounds", "(Z)Ljava/util/regex/Matcher;");
		}
	}
}
