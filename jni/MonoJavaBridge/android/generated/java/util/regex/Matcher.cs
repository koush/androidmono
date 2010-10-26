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
		internal static global::MonoJavaBridge.MethodId _group28272;
		public global::java.lang.String group() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._group28272)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._group28272)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _group28273;
		public global::java.lang.String group(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._group28273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._group28273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString28274;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._toString28274)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._toString28274)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _matches28275;
		public bool matches() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._matches28275);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._matches28275);
		}
		internal static global::MonoJavaBridge.MethodId _replaceFirst28276;
		public global::java.lang.String replaceFirst(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._replaceFirst28276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._replaceFirst28276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _replaceAll28277;
		public global::java.lang.String replaceAll(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._replaceAll28277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._replaceAll28277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _quoteReplacement28278;
		public static global::java.lang.String quoteReplacement(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._quoteReplacement28278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _find28279;
		public bool find() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._find28279);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._find28279);
		}
		internal static global::MonoJavaBridge.MethodId _find28280;
		public bool find(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._find28280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._find28280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _start28281;
		public int start(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._start28281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._start28281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _start28282;
		public int start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._start28282);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._start28282);
		}
		internal static global::MonoJavaBridge.MethodId _reset28283;
		public global::java.util.regex.Matcher reset(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._reset28283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._reset28283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
		}
		public java.util.regex.Matcher reset(string arg0)
		{
			return reset((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _reset28284;
		public global::java.util.regex.Matcher reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._reset28284)) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._reset28284)) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _appendReplacement28285;
		public global::java.util.regex.Matcher appendReplacement(java.lang.StringBuffer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._appendReplacement28285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._appendReplacement28285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _appendTail28286;
		public global::java.lang.StringBuffer appendTail(java.lang.StringBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._appendTail28286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._appendTail28286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _end28287;
		public int end(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._end28287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._end28287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _end28288;
		public int end() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._end28288);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._end28288);
		}
		internal static global::MonoJavaBridge.MethodId _pattern28289;
		public global::java.util.regex.Pattern pattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Pattern>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._pattern28289)) as java.util.regex.Pattern;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Pattern>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._pattern28289)) as java.util.regex.Pattern;
		}
		internal static global::MonoJavaBridge.MethodId _hitEnd28290;
		public bool hitEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._hitEnd28290);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hitEnd28290);
		}
		internal static global::MonoJavaBridge.MethodId _requireEnd28291;
		public bool requireEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._requireEnd28291);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._requireEnd28291);
		}
		internal static global::MonoJavaBridge.MethodId _toMatchResult28292;
		public global::java.util.regex.MatchResult toMatchResult() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._toMatchResult28292)) as java.util.regex.MatchResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._toMatchResult28292)) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _usePattern28293;
		public global::java.util.regex.Matcher usePattern(java.util.regex.Pattern arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._usePattern28293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._usePattern28293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _groupCount28294;
		public int groupCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._groupCount28294);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._groupCount28294);
		}
		internal static global::MonoJavaBridge.MethodId _lookingAt28295;
		public bool lookingAt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._lookingAt28295);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._lookingAt28295);
		}
		internal static global::MonoJavaBridge.MethodId _region28296;
		public global::java.util.regex.Matcher region(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._region28296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._region28296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _regionStart28297;
		public int regionStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._regionStart28297);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._regionStart28297);
		}
		internal static global::MonoJavaBridge.MethodId _regionEnd28298;
		public int regionEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._regionEnd28298);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._regionEnd28298);
		}
		internal static global::MonoJavaBridge.MethodId _hasTransparentBounds28299;
		public bool hasTransparentBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._hasTransparentBounds28299);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hasTransparentBounds28299);
		}
		internal static global::MonoJavaBridge.MethodId _useTransparentBounds28300;
		public global::java.util.regex.Matcher useTransparentBounds(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._useTransparentBounds28300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._useTransparentBounds28300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _hasAnchoringBounds28301;
		public bool hasAnchoringBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._hasAnchoringBounds28301);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hasAnchoringBounds28301);
		}
		internal static global::MonoJavaBridge.MethodId _useAnchoringBounds28302;
		public global::java.util.regex.Matcher useAnchoringBounds(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._useAnchoringBounds28302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Matcher>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._useAnchoringBounds28302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.regex.Matcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/regex/Matcher"));
			global::java.util.regex.Matcher._group28272 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "group", "()Ljava/lang/String;");
			global::java.util.regex.Matcher._group28273 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "group", "(I)Ljava/lang/String;");
			global::java.util.regex.Matcher._toString28274 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.regex.Matcher._matches28275 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "matches", "()Z");
			global::java.util.regex.Matcher._replaceFirst28276 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "replaceFirst", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.regex.Matcher._replaceAll28277 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "replaceAll", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.regex.Matcher._quoteReplacement28278 = @__env.GetStaticMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "quoteReplacement", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.regex.Matcher._find28279 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "find", "()Z");
			global::java.util.regex.Matcher._find28280 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "find", "(I)Z");
			global::java.util.regex.Matcher._start28281 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "start", "(I)I");
			global::java.util.regex.Matcher._start28282 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "start", "()I");
			global::java.util.regex.Matcher._reset28283 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "reset", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._reset28284 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "reset", "()Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._appendReplacement28285 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "appendReplacement", "(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._appendTail28286 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "appendTail", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
			global::java.util.regex.Matcher._end28287 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "end", "(I)I");
			global::java.util.regex.Matcher._end28288 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "end", "()I");
			global::java.util.regex.Matcher._pattern28289 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "pattern", "()Ljava/util/regex/Pattern;");
			global::java.util.regex.Matcher._hitEnd28290 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "hitEnd", "()Z");
			global::java.util.regex.Matcher._requireEnd28291 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "requireEnd", "()Z");
			global::java.util.regex.Matcher._toMatchResult28292 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "toMatchResult", "()Ljava/util/regex/MatchResult;");
			global::java.util.regex.Matcher._usePattern28293 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "usePattern", "(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._groupCount28294 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "groupCount", "()I");
			global::java.util.regex.Matcher._lookingAt28295 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "lookingAt", "()Z");
			global::java.util.regex.Matcher._region28296 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "region", "(II)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._regionStart28297 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "regionStart", "()I");
			global::java.util.regex.Matcher._regionEnd28298 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "regionEnd", "()I");
			global::java.util.regex.Matcher._hasTransparentBounds28299 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "hasTransparentBounds", "()Z");
			global::java.util.regex.Matcher._useTransparentBounds28300 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "useTransparentBounds", "(Z)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._hasAnchoringBounds28301 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "hasAnchoringBounds", "()Z");
			global::java.util.regex.Matcher._useAnchoringBounds28302 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "useAnchoringBounds", "(Z)Ljava/util/regex/Matcher;");
		}
	}
}
