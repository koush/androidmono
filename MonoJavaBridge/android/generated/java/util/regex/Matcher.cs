namespace java.util.regex
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Matcher : java.lang.Object, MatchResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Matcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::java.lang.String group()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.Matcher.staticClass, "group", "()Ljava/lang/String;", ref global::java.util.regex.Matcher._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::java.lang.String group(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.Matcher.staticClass, "group", "(I)Ljava/lang/String;", ref global::java.util.regex.Matcher._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.Matcher.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.regex.Matcher._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public bool matches()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "matches", "()Z", ref global::java.util.regex.Matcher._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.lang.String replaceFirst(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.Matcher.staticClass, "replaceFirst", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.regex.Matcher._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::java.lang.String replaceAll(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.Matcher.staticClass, "replaceAll", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.regex.Matcher._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.lang.String quoteReplacement(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.regex.Matcher._m6.native == global::System.IntPtr.Zero)
				global::java.util.regex.Matcher._m6 = @__env.GetStaticMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "quoteReplacement", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public bool find()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "find", "()Z", ref global::java.util.regex.Matcher._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public bool find(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "find", "(I)Z", ref global::java.util.regex.Matcher._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public int start(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Matcher.staticClass, "start", "(I)I", ref global::java.util.regex.Matcher._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public int start()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Matcher.staticClass, "start", "()I", ref global::java.util.regex.Matcher._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public global::java.util.regex.Matcher reset(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Matcher.staticClass, "reset", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;", ref global::java.util.regex.Matcher._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.regex.Matcher;
		}
		public java.util.regex.Matcher reset(string arg0)
		{
			return reset((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::java.util.regex.Matcher reset()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Matcher.staticClass, "reset", "()Ljava/util/regex/Matcher;", ref global::java.util.regex.Matcher._m12) as java.util.regex.Matcher;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.util.regex.Matcher appendReplacement(java.lang.StringBuffer arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Matcher.staticClass, "appendReplacement", "(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;", ref global::java.util.regex.Matcher._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.regex.Matcher;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public global::java.lang.StringBuffer appendTail(java.lang.StringBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.util.regex.Matcher.staticClass, "appendTail", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", ref global::java.util.regex.Matcher._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public int end(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Matcher.staticClass, "end", "(I)I", ref global::java.util.regex.Matcher._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public int end()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Matcher.staticClass, "end", "()I", ref global::java.util.regex.Matcher._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public global::java.util.regex.Pattern pattern()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Pattern>(this, global::java.util.regex.Matcher.staticClass, "pattern", "()Ljava/util/regex/Pattern;", ref global::java.util.regex.Matcher._m17) as java.util.regex.Pattern;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public bool hitEnd()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "hitEnd", "()Z", ref global::java.util.regex.Matcher._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public bool requireEnd()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "requireEnd", "()Z", ref global::java.util.regex.Matcher._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public global::java.util.regex.MatchResult toMatchResult()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.regex.MatchResult>(this, global::java.util.regex.Matcher.staticClass, "toMatchResult", "()Ljava/util/regex/MatchResult;", ref global::java.util.regex.Matcher._m20) as java.util.regex.MatchResult;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public global::java.util.regex.Matcher usePattern(java.util.regex.Pattern arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Matcher.staticClass, "usePattern", "(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;", ref global::java.util.regex.Matcher._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.regex.Matcher;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public int groupCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Matcher.staticClass, "groupCount", "()I", ref global::java.util.regex.Matcher._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public bool lookingAt()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "lookingAt", "()Z", ref global::java.util.regex.Matcher._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public global::java.util.regex.Matcher region(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Matcher.staticClass, "region", "(II)Ljava/util/regex/Matcher;", ref global::java.util.regex.Matcher._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.regex.Matcher;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public int regionStart()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Matcher.staticClass, "regionStart", "()I", ref global::java.util.regex.Matcher._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public int regionEnd()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.Matcher.staticClass, "regionEnd", "()I", ref global::java.util.regex.Matcher._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public bool hasTransparentBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "hasTransparentBounds", "()Z", ref global::java.util.regex.Matcher._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public global::java.util.regex.Matcher useTransparentBounds(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Matcher.staticClass, "useTransparentBounds", "(Z)Ljava/util/regex/Matcher;", ref global::java.util.regex.Matcher._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.regex.Matcher;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public bool hasAnchoringBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.regex.Matcher.staticClass, "hasAnchoringBounds", "()Z", ref global::java.util.regex.Matcher._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public global::java.util.regex.Matcher useAnchoringBounds(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Matcher>(this, global::java.util.regex.Matcher.staticClass, "useAnchoringBounds", "(Z)Ljava/util/regex/Matcher;", ref global::java.util.regex.Matcher._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.regex.Matcher;
		}
		static Matcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.regex.Matcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/regex/Matcher"));
		}
	}
}
