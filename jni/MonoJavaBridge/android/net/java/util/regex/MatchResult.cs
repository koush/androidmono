namespace java.util.regex 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface MatchResult 
	{ 
		java.lang.String group(); 
		java.lang.String group(int arg0); 
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
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.regex.__MatchResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _group13053; 
		 java.lang.String java.util.regex.MatchResult.group() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.__MatchResult)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _group13053)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.__MatchResult.staticClass, _group13053)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _group13054; 
		 java.lang.String java.util.regex.MatchResult.group(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.__MatchResult)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _group13054, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.regex.__MatchResult.staticClass, _group13054, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start13055; 
		 int java.util.regex.MatchResult.start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.__MatchResult)) 
				return @__env.CallIntMethod(this, _start13055); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.regex.__MatchResult.staticClass, _start13055); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start13056; 
		 int java.util.regex.MatchResult.start(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.__MatchResult)) 
				return @__env.CallIntMethod(this, _start13056, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.regex.__MatchResult.staticClass, _start13056, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _end13057; 
		 int java.util.regex.MatchResult.end() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.__MatchResult)) 
				return @__env.CallIntMethod(this, _end13057); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.regex.__MatchResult.staticClass, _end13057); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _end13058; 
		 int java.util.regex.MatchResult.end(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.__MatchResult)) 
				return @__env.CallIntMethod(this, _end13058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.regex.__MatchResult.staticClass, _end13058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _groupCount13059; 
		 int java.util.regex.MatchResult.groupCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.regex.__MatchResult)) 
				return @__env.CallIntMethod(this, _groupCount13059); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.regex.__MatchResult.staticClass, _groupCount13059); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.regex.__MatchResult.staticClass = @__class; 
			global::java.util.regex.__MatchResult._group13053 = @__env.GetMethodID(global::java.util.regex.__MatchResult.staticClass, "java.util.regex.MatchResult.group", "()Ljava/lang/String;"); 
			global::java.util.regex.__MatchResult._group13054 = @__env.GetMethodID(global::java.util.regex.__MatchResult.staticClass, "java.util.regex.MatchResult.group", "(I)Ljava/lang/String;"); 
			global::java.util.regex.__MatchResult._start13055 = @__env.GetMethodID(global::java.util.regex.__MatchResult.staticClass, "java.util.regex.MatchResult.start", "()I"); 
			global::java.util.regex.__MatchResult._start13056 = @__env.GetMethodID(global::java.util.regex.__MatchResult.staticClass, "java.util.regex.MatchResult.start", "(I)I"); 
			global::java.util.regex.__MatchResult._end13057 = @__env.GetMethodID(global::java.util.regex.__MatchResult.staticClass, "java.util.regex.MatchResult.end", "()I"); 
			global::java.util.regex.__MatchResult._end13058 = @__env.GetMethodID(global::java.util.regex.__MatchResult.staticClass, "java.util.regex.MatchResult.end", "(I)I"); 
			global::java.util.regex.__MatchResult._groupCount13059 = @__env.GetMethodID(global::java.util.regex.__MatchResult.staticClass, "java.util.regex.MatchResult.groupCount", "()I"); 
		} 
	} 
} 
