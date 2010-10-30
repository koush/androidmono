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
		internal MatchResult_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _group28266;
		global::java.lang.String java.util.regex.MatchResult.group()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.MatchResult_.staticClass, "group", "()Ljava/lang/String;", ref global::java.util.regex.MatchResult_._group28266) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _group28267;
		global::java.lang.String java.util.regex.MatchResult.group(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.MatchResult_.staticClass, "group", "(I)Ljava/lang/String;", ref global::java.util.regex.MatchResult_._group28267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _start28268;
		int java.util.regex.MatchResult.start()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.MatchResult_.staticClass, "start", "()I", ref global::java.util.regex.MatchResult_._start28268);
		}
		internal static global::MonoJavaBridge.MethodId _start28269;
		int java.util.regex.MatchResult.start(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.MatchResult_.staticClass, "start", "(I)I", ref global::java.util.regex.MatchResult_._start28269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _end28270;
		int java.util.regex.MatchResult.end()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.MatchResult_.staticClass, "end", "()I", ref global::java.util.regex.MatchResult_._end28270);
		}
		internal static global::MonoJavaBridge.MethodId _end28271;
		int java.util.regex.MatchResult.end(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.MatchResult_.staticClass, "end", "(I)I", ref global::java.util.regex.MatchResult_._end28271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _groupCount28272;
		int java.util.regex.MatchResult.groupCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.MatchResult_.staticClass, "groupCount", "()I", ref global::java.util.regex.MatchResult_._groupCount28272);
		}
		static MatchResult_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.regex.MatchResult_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/regex/MatchResult"));
		}
		internal static void InitJNI()
		{
		}
	}
}
