namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TimingLogger : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static TimingLogger() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.util.TimingLogger), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.util.TimingLogger(@__env); 
			} 
		} 
		protected TimingLogger(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset7652; 
		public virtual void reset(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.TimingLogger)) 
				@__env.CallVoidMethod(this, _reset7652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.TimingLogger.staticClass, _reset7652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset7653; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.TimingLogger)) 
				@__env.CallVoidMethod(this, _reset7653); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.TimingLogger.staticClass, _reset7653); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addSplit7654; 
		public virtual void addSplit(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.TimingLogger)) 
				@__env.CallVoidMethod(this, _addSplit7654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.TimingLogger.staticClass, _addSplit7654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpToLog7655; 
		public virtual void dumpToLog() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.TimingLogger)) 
				@__env.CallVoidMethod(this, _dumpToLog7655); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.TimingLogger.staticClass, _dumpToLog7655); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TimingLogger7656; 
		public TimingLogger(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.TimingLogger.staticClass, _TimingLogger7656, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.TimingLogger.staticClass = @__class; 
			global::android.util.TimingLogger._reset7652 = @__env.GetMethodID(global::android.util.TimingLogger.staticClass, "reset", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.util.TimingLogger._reset7653 = @__env.GetMethodID(global::android.util.TimingLogger.staticClass, "reset", "()V"); 
			global::android.util.TimingLogger._addSplit7654 = @__env.GetMethodID(global::android.util.TimingLogger.staticClass, "addSplit", "(Ljava/lang/String;)V"); 
			global::android.util.TimingLogger._dumpToLog7655 = @__env.GetMethodID(global::android.util.TimingLogger.staticClass, "dumpToLog", "()V"); 
			global::android.util.TimingLogger._TimingLogger7656 = @__env.GetMethodID(global::android.util.TimingLogger.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"); 
		} 
	} 
} 
