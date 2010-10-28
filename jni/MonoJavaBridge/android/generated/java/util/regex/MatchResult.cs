namespace java.util.regex
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.regex.MatchResult_))]
	public partial interface MatchResult  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String group();
		global::java.lang.String group(int arg0);
		int start();
		int start(int arg0);
		int end();
		int end(int arg0);
		int groupCount();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.regex.MatchResult))]
	internal sealed partial class MatchResult_ : java.lang.Object, MatchResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MatchResult_()
		{
			InitJNI();
		}
		internal MatchResult_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _group28266;
		global::java.lang.String java.util.regex.MatchResult.group()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_._group28266)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._group28266)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _group28267;
		global::java.lang.String java.util.regex.MatchResult.group(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_._group28267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._group28267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _start28268;
		int java.util.regex.MatchResult.start()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._start28268);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._start28268);
		}
		internal static global::MonoJavaBridge.MethodId _start28269;
		int java.util.regex.MatchResult.start(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._start28269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._start28269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _end28270;
		int java.util.regex.MatchResult.end()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._end28270);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._end28270);
		}
		internal static global::MonoJavaBridge.MethodId _end28271;
		int java.util.regex.MatchResult.end(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._end28271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._end28271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _groupCount28272;
		int java.util.regex.MatchResult.groupCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._groupCount28272);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._groupCount28272);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.regex.MatchResult_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/regex/MatchResult"));
			global::java.util.regex.MatchResult_._group28266 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "group", "()Ljava/lang/String;");
			global::java.util.regex.MatchResult_._group28267 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "group", "(I)Ljava/lang/String;");
			global::java.util.regex.MatchResult_._start28268 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "start", "()I");
			global::java.util.regex.MatchResult_._start28269 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "start", "(I)I");
			global::java.util.regex.MatchResult_._end28270 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "end", "()I");
			global::java.util.regex.MatchResult_._end28271 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "end", "(I)I");
			global::java.util.regex.MatchResult_._groupCount28272 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "groupCount", "()I");
		}
	}
}
