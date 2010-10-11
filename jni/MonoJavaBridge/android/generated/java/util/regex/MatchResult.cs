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
		internal static global::MonoJavaBridge.MethodId _group15748;
		 global::java.lang.String java.util.regex.MatchResult.group() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_._group15748)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._group15748)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _group15749;
		 global::java.lang.String java.util.regex.MatchResult.group(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_._group15749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._group15749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _start15750;
		 int java.util.regex.MatchResult.start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._start15750);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._start15750);
		}
		internal static global::MonoJavaBridge.MethodId _start15751;
		 int java.util.regex.MatchResult.start(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._start15751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._start15751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _end15752;
		 int java.util.regex.MatchResult.end() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._end15752);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._end15752);
		}
		internal static global::MonoJavaBridge.MethodId _end15753;
		 int java.util.regex.MatchResult.end(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._end15753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._end15753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _groupCount15754;
		 int java.util.regex.MatchResult.groupCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_._groupCount15754);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.MatchResult_.staticClass, global::java.util.regex.MatchResult_._groupCount15754);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.regex.MatchResult_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/regex/MatchResult"));
			global::java.util.regex.MatchResult_._group15748 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "group", "()Ljava/lang/String;");
			global::java.util.regex.MatchResult_._group15749 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "group", "(I)Ljava/lang/String;");
			global::java.util.regex.MatchResult_._start15750 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "start", "()I");
			global::java.util.regex.MatchResult_._start15751 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "start", "(I)I");
			global::java.util.regex.MatchResult_._end15752 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "end", "()I");
			global::java.util.regex.MatchResult_._end15753 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "end", "(I)I");
			global::java.util.regex.MatchResult_._groupCount15754 = @__env.GetMethodIDNoThrow(global::java.util.regex.MatchResult_.staticClass, "groupCount", "()I");
		}
	}
}
