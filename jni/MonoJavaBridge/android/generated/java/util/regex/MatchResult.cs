namespace java.util.regex
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.regex.MatchResult_))]
	public interface MatchResult  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class MatchResult_ : java.lang.Object, MatchResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MatchResult_()
		{
			InitJNI();
		}
		internal MatchResult_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _group22281;
		 global::java.lang.String java.util.regex.MatchResult.group() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_._group22281)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._group22281)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _group22282;
		 global::java.lang.String java.util.regex.MatchResult.group(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_._group22282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._group22282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _start22283;
		 int java.util.regex.MatchResult.start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._start22283);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._start22283);
		}
		internal static global::MonoJavaBridge.MethodId _start22284;
		 int java.util.regex.MatchResult.start(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._start22284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._start22284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _end22285;
		 int java.util.regex.MatchResult.end() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._end22285);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._end22285);
		}
		internal static global::MonoJavaBridge.MethodId _end22286;
		 int java.util.regex.MatchResult.end(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._end22286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._end22286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _groupCount22287;
		 int java.util.regex.MatchResult.groupCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._groupCount22287);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._groupCount22287);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.regex.MatchResult_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/regex/MatchResult"));
			global::java.util.regex.MatchResult_._group22281 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "group", "()Ljava/lang/String;");
			global::java.util.regex.MatchResult_._group22282 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "group", "(I)Ljava/lang/String;");
			global::java.util.regex.MatchResult_._start22283 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "start", "()I");
			global::java.util.regex.MatchResult_._start22284 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "start", "(I)I");
			global::java.util.regex.MatchResult_._end22285 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "end", "()I");
			global::java.util.regex.MatchResult_._end22286 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "end", "(I)I");
			global::java.util.regex.MatchResult_._groupCount22287 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "groupCount", "()I");
		}
	}
}
