namespace java.util.regex
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Matcher : java.lang.Object, MatchResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Matcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _group28273;
		public global::java.lang.String group()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.Matcher.staticClass, "group", "()Ljava/lang/String;", ref global::java.util.regex.Matcher._group28273) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _group28274;
		public global::java.lang.String group(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.Matcher.staticClass, "group", "(I)Ljava/lang/String;", ref global::java.util.regex.Matcher._group28274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString28275;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.Matcher.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.regex.Matcher._toString28275) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _matches28276;
		public bool matches()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "matches", "()Z", ref global::java.util.regex.Matcher._matches28276);
		}
		internal static global::MonoJavaBridge.MethodId _replaceFirst28277;
		public global::java.lang.String replaceFirst(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.Matcher.staticClass, "replaceFirst", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.regex.Matcher._replaceFirst28277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _replaceAll28278;
		public global::java.lang.String replaceAll(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.Matcher.staticClass, "replaceAll", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.regex.Matcher._replaceAll28278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _quoteReplacement28279;
		public static global::java.lang.String quoteReplacement(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.regex.Matcher._quoteReplacement28279.native == global::System.IntPtr.Zero)
				global::java.util.regex.Matcher._quoteReplacement28279 = @__env.GetStaticMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "quoteReplacement", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._quoteReplacement28279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _find28280;
		public bool find()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "find", "()Z", ref global::java.util.regex.Matcher._find28280);
		}
		internal static global::MonoJavaBridge.MethodId _find28281;
		public bool find(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "find", "(I)Z", ref global::java.util.regex.Matcher._find28281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _start28282;
		public int start(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Matcher.staticClass, "start", "(I)I", ref global::java.util.regex.Matcher._start28282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _start28283;
		public int start()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Matcher.staticClass, "start", "()I", ref global::java.util.regex.Matcher._start28283);
		}
		internal static global::MonoJavaBridge.MethodId _reset28284;
		public global::java.util.regex.Matcher reset(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Matcher.staticClass, "reset", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;", ref global::java.util.regex.Matcher._reset28284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.regex.Matcher;
		}
		public java.util.regex.Matcher reset(string arg0)
		{
			return reset((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _reset28285;
		public global::java.util.regex.Matcher reset()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Matcher.staticClass, "reset", "()Ljava/util/regex/Matcher;", ref global::java.util.regex.Matcher._reset28285) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _appendReplacement28286;
		public global::java.util.regex.Matcher appendReplacement(java.lang.StringBuffer arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Matcher.staticClass, "appendReplacement", "(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;", ref global::java.util.regex.Matcher._appendReplacement28286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _appendTail28287;
		public global::java.lang.StringBuffer appendTail(java.lang.StringBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.util.regex.Matcher.staticClass, "appendTail", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", ref global::java.util.regex.Matcher._appendTail28287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _end28288;
		public int end(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Matcher.staticClass, "end", "(I)I", ref global::java.util.regex.Matcher._end28288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _end28289;
		public int end()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Matcher.staticClass, "end", "()I", ref global::java.util.regex.Matcher._end28289);
		}
		internal static global::MonoJavaBridge.MethodId _pattern28290;
		public global::java.util.regex.Pattern pattern()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Pattern>(this, global::java.util.regex.Matcher.staticClass, "pattern", "()Ljava/util/regex/Pattern;", ref global::java.util.regex.Matcher._pattern28290) as java.util.regex.Pattern;
		}
		internal static global::MonoJavaBridge.MethodId _hitEnd28291;
		public bool hitEnd()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "hitEnd", "()Z", ref global::java.util.regex.Matcher._hitEnd28291);
		}
		internal static global::MonoJavaBridge.MethodId _requireEnd28292;
		public bool requireEnd()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "requireEnd", "()Z", ref global::java.util.regex.Matcher._requireEnd28292);
		}
		internal static global::MonoJavaBridge.MethodId _toMatchResult28293;
		public global::java.util.regex.MatchResult toMatchResult()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.regex.MatchResult>(this, global::java.util.regex.Matcher.staticClass, "toMatchResult", "()Ljava/util/regex/MatchResult;", ref global::java.util.regex.Matcher._toMatchResult28293) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _usePattern28294;
		public global::java.util.regex.Matcher usePattern(java.util.regex.Pattern arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Matcher.staticClass, "usePattern", "(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;", ref global::java.util.regex.Matcher._usePattern28294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _groupCount28295;
		public int groupCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Matcher.staticClass, "groupCount", "()I", ref global::java.util.regex.Matcher._groupCount28295);
		}
		internal static global::MonoJavaBridge.MethodId _lookingAt28296;
		public bool lookingAt()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "lookingAt", "()Z", ref global::java.util.regex.Matcher._lookingAt28296);
		}
		internal static global::MonoJavaBridge.MethodId _region28297;
		public global::java.util.regex.Matcher region(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Matcher.staticClass, "region", "(II)Ljava/util/regex/Matcher;", ref global::java.util.regex.Matcher._region28297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _regionStart28298;
		public int regionStart()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Matcher.staticClass, "regionStart", "()I", ref global::java.util.regex.Matcher._regionStart28298);
		}
		internal static global::MonoJavaBridge.MethodId _regionEnd28299;
		public int regionEnd()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Matcher.staticClass, "regionEnd", "()I", ref global::java.util.regex.Matcher._regionEnd28299);
		}
		internal static global::MonoJavaBridge.MethodId _hasTransparentBounds28300;
		public bool hasTransparentBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "hasTransparentBounds", "()Z", ref global::java.util.regex.Matcher._hasTransparentBounds28300);
		}
		internal static global::MonoJavaBridge.MethodId _useTransparentBounds28301;
		public global::java.util.regex.Matcher useTransparentBounds(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Matcher.staticClass, "useTransparentBounds", "(Z)Ljava/util/regex/Matcher;", ref global::java.util.regex.Matcher._useTransparentBounds28301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _hasAnchoringBounds28302;
		public bool hasAnchoringBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "hasAnchoringBounds", "()Z", ref global::java.util.regex.Matcher._hasAnchoringBounds28302);
		}
		internal static global::MonoJavaBridge.MethodId _useAnchoringBounds28303;
		public global::java.util.regex.Matcher useAnchoringBounds(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Matcher.staticClass, "useAnchoringBounds", "(Z)Ljava/util/regex/Matcher;", ref global::java.util.regex.Matcher._useAnchoringBounds28303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.regex.Matcher;
		}
		static Matcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.regex.Matcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/regex/Matcher"));
		}
		internal static void InitJNI()
		{
		}
	}
}
