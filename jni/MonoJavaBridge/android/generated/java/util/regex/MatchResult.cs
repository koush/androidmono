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
		internal static global::MonoJavaBridge.MethodId _group28147;
		 global::java.lang.String java.util.regex.MatchResult.group() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_._group28147)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._group28147)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _group28148;
		 global::java.lang.String java.util.regex.MatchResult.group(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_._group28148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._group28148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _start28149;
		 int java.util.regex.MatchResult.start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._start28149);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._start28149);
		}
		internal static global::MonoJavaBridge.MethodId _start28150;
		 int java.util.regex.MatchResult.start(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._start28150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._start28150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _end28151;
		 int java.util.regex.MatchResult.end() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._end28151);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._end28151);
		}
		internal static global::MonoJavaBridge.MethodId _end28152;
		 int java.util.regex.MatchResult.end(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._end28152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._end28152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _groupCount28153;
		 int java.util.regex.MatchResult.groupCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._groupCount28153);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._groupCount28153);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.regex.MatchResult_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/regex/MatchResult"));
			global::java.util.regex.MatchResult_._group28147 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "group", "()Ljava/lang/String;");
			global::java.util.regex.MatchResult_._group28148 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "group", "(I)Ljava/lang/String;");
			global::java.util.regex.MatchResult_._start28149 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "start", "()I");
			global::java.util.regex.MatchResult_._start28150 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "start", "(I)I");
			global::java.util.regex.MatchResult_._end28151 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "end", "()I");
			global::java.util.regex.MatchResult_._end28152 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "end", "(I)I");
			global::java.util.regex.MatchResult_._groupCount28153 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "groupCount", "()I");
		}
	}
}
