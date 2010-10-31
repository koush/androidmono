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
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String java.util.regex.MatchResult.group()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.MatchResult_.staticClass, "group", "()Ljava/lang/String;", ref global::java.util.regex.MatchResult_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String java.util.regex.MatchResult.group(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.MatchResult_.staticClass, "group", "(I)Ljava/lang/String;", ref global::java.util.regex.MatchResult_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int java.util.regex.MatchResult.start()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.MatchResult_.staticClass, "start", "()I", ref global::java.util.regex.MatchResult_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int java.util.regex.MatchResult.start(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.MatchResult_.staticClass, "start", "(I)I", ref global::java.util.regex.MatchResult_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int java.util.regex.MatchResult.end()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.MatchResult_.staticClass, "end", "()I", ref global::java.util.regex.MatchResult_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		int java.util.regex.MatchResult.end(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.MatchResult_.staticClass, "end", "(I)I", ref global::java.util.regex.MatchResult_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		int java.util.regex.MatchResult.groupCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.MatchResult_.staticClass, "groupCount", "()I", ref global::java.util.regex.MatchResult_._m6);
		}
		static MatchResult_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.regex.MatchResult_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/regex/MatchResult"));
		}
	}
}
