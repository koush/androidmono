namespace java.util.regex
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface MatchResult 
	{
		global::java.lang.String group();
		global::java.lang.String group(int arg0);
		int start();
		int start(int arg0);
		int end();
		int end(int arg0);
		int groupCount();
	}

	public partial class MatchResult_
	{
		public static global::java.lang.Class _class
		{
			get { return __MatchResult.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __MatchResult : java.lang.Object, MatchResult
	{
		internal static global::java.lang.Class staticClass;
		static __MatchResult()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.regex.__MatchResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.util.regex.__MatchResult(@__env);
			}
		}
		internal __MatchResult(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _group13884;
		 global::java.lang.String java.util.regex.MatchResult.group() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.__MatchResult._group13884));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.__MatchResult.staticClass, global::java.util.regex.__MatchResult._group13884));
		}
		internal static global::net.sf.jni4net.jni.MethodId _group13885;
		 global::java.lang.String java.util.regex.MatchResult.group(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.__MatchResult._group13885, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.__MatchResult.staticClass, global::java.util.regex.__MatchResult._group13885, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _start13886;
		 int java.util.regex.MatchResult.start() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.regex.__MatchResult._start13886);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.__MatchResult.staticClass, global::java.util.regex.__MatchResult._start13886);
		}
		internal static global::net.sf.jni4net.jni.MethodId _start13887;
		 int java.util.regex.MatchResult.start(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.regex.__MatchResult._start13887, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.__MatchResult.staticClass, global::java.util.regex.__MatchResult._start13887, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _end13888;
		 int java.util.regex.MatchResult.end() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.regex.__MatchResult._end13888);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.__MatchResult.staticClass, global::java.util.regex.__MatchResult._end13888);
		}
		internal static global::net.sf.jni4net.jni.MethodId _end13889;
		 int java.util.regex.MatchResult.end(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.regex.__MatchResult._end13889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.__MatchResult.staticClass, global::java.util.regex.__MatchResult._end13889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _groupCount13890;
		 int java.util.regex.MatchResult.groupCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.regex.__MatchResult._groupCount13890);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.__MatchResult.staticClass, global::java.util.regex.__MatchResult._groupCount13890);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.regex.__MatchResult.staticClass = @__class;
			global::java.util.regex.__MatchResult._group13884 = @__env.GetMethodID(global::java.util.regex.__MatchResult.staticClass, "java.util.regex.MatchResult.group", "()Ljava/lang/String;");
			global::java.util.regex.__MatchResult._group13885 = @__env.GetMethodID(global::java.util.regex.__MatchResult.staticClass, "java.util.regex.MatchResult.group", "(I)Ljava/lang/String;");
			global::java.util.regex.__MatchResult._start13886 = @__env.GetMethodID(global::java.util.regex.__MatchResult.staticClass, "java.util.regex.MatchResult.start", "()I");
			global::java.util.regex.__MatchResult._start13887 = @__env.GetMethodID(global::java.util.regex.__MatchResult.staticClass, "java.util.regex.MatchResult.start", "(I)I");
			global::java.util.regex.__MatchResult._end13888 = @__env.GetMethodID(global::java.util.regex.__MatchResult.staticClass, "java.util.regex.MatchResult.end", "()I");
			global::java.util.regex.__MatchResult._end13889 = @__env.GetMethodID(global::java.util.regex.__MatchResult.staticClass, "java.util.regex.MatchResult.end", "(I)I");
			global::java.util.regex.__MatchResult._groupCount13890 = @__env.GetMethodID(global::java.util.regex.__MatchResult.staticClass, "java.util.regex.MatchResult.groupCount", "()I");
		}
	}
}
