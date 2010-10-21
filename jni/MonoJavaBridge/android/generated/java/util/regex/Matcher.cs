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
		internal static global::MonoJavaBridge.MethodId _group28154;
		public global::java.lang.String group() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._group28154)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._group28154)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _group28155;
		public global::java.lang.String group(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._group28155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._group28155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString28156;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._toString28156)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._toString28156)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _matches28157;
		public bool matches() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._matches28157);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._matches28157);
		}
		internal static global::MonoJavaBridge.MethodId _replaceFirst28158;
		public global::java.lang.String replaceFirst(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._replaceFirst28158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._replaceFirst28158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _replaceAll28159;
		public global::java.lang.String replaceAll(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._replaceAll28159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._replaceAll28159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _quoteReplacement28160;
		public static global::java.lang.String quoteReplacement(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._quoteReplacement28160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _find28161;
		public bool find() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._find28161);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._find28161);
		}
		internal static global::MonoJavaBridge.MethodId _find28162;
		public bool find(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._find28162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._find28162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _start28163;
		public int start(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._start28163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._start28163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _start28164;
		public int start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._start28164);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._start28164);
		}
		internal static global::MonoJavaBridge.MethodId _reset28165;
		public global::java.util.regex.Matcher reset(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._reset28165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._reset28165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
		}
		public java.util.regex.Matcher reset(string arg0)
		{
			return reset((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _reset28166;
		public global::java.util.regex.Matcher reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._reset28166)) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._reset28166)) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _appendReplacement28167;
		public global::java.util.regex.Matcher appendReplacement(java.lang.StringBuffer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._appendReplacement28167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._appendReplacement28167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _appendTail28168;
		public global::java.lang.StringBuffer appendTail(java.lang.StringBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._appendTail28168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._appendTail28168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _end28169;
		public int end(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._end28169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._end28169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _end28170;
		public int end() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._end28170);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._end28170);
		}
		internal static global::MonoJavaBridge.MethodId _pattern28171;
		public global::java.util.regex.Pattern pattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._pattern28171)) as java.util.regex.Pattern;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._pattern28171)) as java.util.regex.Pattern;
		}
		internal static global::MonoJavaBridge.MethodId _hitEnd28172;
		public bool hitEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._hitEnd28172);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hitEnd28172);
		}
		internal static global::MonoJavaBridge.MethodId _requireEnd28173;
		public bool requireEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._requireEnd28173);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._requireEnd28173);
		}
		internal static global::MonoJavaBridge.MethodId _toMatchResult28174;
		public global::java.util.regex.MatchResult toMatchResult() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._toMatchResult28174)) as java.util.regex.MatchResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._toMatchResult28174)) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _usePattern28175;
		public global::java.util.regex.Matcher usePattern(java.util.regex.Pattern arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._usePattern28175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._usePattern28175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _groupCount28176;
		public int groupCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._groupCount28176);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._groupCount28176);
		}
		internal static global::MonoJavaBridge.MethodId _lookingAt28177;
		public bool lookingAt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._lookingAt28177);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._lookingAt28177);
		}
		internal static global::MonoJavaBridge.MethodId _region28178;
		public global::java.util.regex.Matcher region(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._region28178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._region28178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _regionStart28179;
		public int regionStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._regionStart28179);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._regionStart28179);
		}
		internal static global::MonoJavaBridge.MethodId _regionEnd28180;
		public int regionEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.Matcher._regionEnd28180);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._regionEnd28180);
		}
		internal static global::MonoJavaBridge.MethodId _hasTransparentBounds28181;
		public bool hasTransparentBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._hasTransparentBounds28181);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hasTransparentBounds28181);
		}
		internal static global::MonoJavaBridge.MethodId _useTransparentBounds28182;
		public global::java.util.regex.Matcher useTransparentBounds(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._useTransparentBounds28182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._useTransparentBounds28182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
		}
		internal static global::MonoJavaBridge.MethodId _hasAnchoringBounds28183;
		public bool hasAnchoringBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher._hasAnchoringBounds28183);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._hasAnchoringBounds28183);
		}
		internal static global::MonoJavaBridge.MethodId _useAnchoringBounds28184;
		public global::java.util.regex.Matcher useAnchoringBounds(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.Matcher._useAnchoringBounds28184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.Matcher.staticClass, global::java.util.regex.Matcher._useAnchoringBounds28184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.regex.Matcher;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.regex.Matcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/regex/Matcher"));
			global::java.util.regex.Matcher._group28154 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "group", "()Ljava/lang/String;");
			global::java.util.regex.Matcher._group28155 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "group", "(I)Ljava/lang/String;");
			global::java.util.regex.Matcher._toString28156 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.regex.Matcher._matches28157 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "matches", "()Z");
			global::java.util.regex.Matcher._replaceFirst28158 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "replaceFirst", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.regex.Matcher._replaceAll28159 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "replaceAll", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.regex.Matcher._quoteReplacement28160 = @__env.GetStaticMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "quoteReplacement", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.regex.Matcher._find28161 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "find", "()Z");
			global::java.util.regex.Matcher._find28162 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "find", "(I)Z");
			global::java.util.regex.Matcher._start28163 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "start", "(I)I");
			global::java.util.regex.Matcher._start28164 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "start", "()I");
			global::java.util.regex.Matcher._reset28165 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "reset", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._reset28166 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "reset", "()Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._appendReplacement28167 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "appendReplacement", "(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._appendTail28168 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "appendTail", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
			global::java.util.regex.Matcher._end28169 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "end", "(I)I");
			global::java.util.regex.Matcher._end28170 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "end", "()I");
			global::java.util.regex.Matcher._pattern28171 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "pattern", "()Ljava/util/regex/Pattern;");
			global::java.util.regex.Matcher._hitEnd28172 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "hitEnd", "()Z");
			global::java.util.regex.Matcher._requireEnd28173 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "requireEnd", "()Z");
			global::java.util.regex.Matcher._toMatchResult28174 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "toMatchResult", "()Ljava/util/regex/MatchResult;");
			global::java.util.regex.Matcher._usePattern28175 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "usePattern", "(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._groupCount28176 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "groupCount", "()I");
			global::java.util.regex.Matcher._lookingAt28177 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "lookingAt", "()Z");
			global::java.util.regex.Matcher._region28178 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "region", "(II)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._regionStart28179 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "regionStart", "()I");
			global::java.util.regex.Matcher._regionEnd28180 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "regionEnd", "()I");
			global::java.util.regex.Matcher._hasTransparentBounds28181 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "hasTransparentBounds", "()Z");
			global::java.util.regex.Matcher._useTransparentBounds28182 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "useTransparentBounds", "(Z)Ljava/util/regex/Matcher;");
			global::java.util.regex.Matcher._hasAnchoringBounds28183 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "hasAnchoringBounds", "()Z");
			global::java.util.regex.Matcher._useAnchoringBounds28184 = @__env.GetMethodIDNoThrow(global::java.util.regex.Matcher.staticClass, "useAnchoringBounds", "(Z)Ljava/util/regex/Matcher;");
		}
	}
}
