namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TimingLogger : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static TimingLogger()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.TimingLogger), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _reset8326;
		public virtual void reset(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.TimingLogger._reset8326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._reset8326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset8327;
		public virtual void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.TimingLogger._reset8327);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._reset8327);
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSplit8328;
		public virtual void addSplit(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.TimingLogger._addSplit8328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._addSplit8328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpToLog8329;
		public virtual void dumpToLog() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.TimingLogger._dumpToLog8329);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._dumpToLog8329);
		}
		internal static global::net.sf.jni4net.jni.MethodId _TimingLogger8330;
		public TimingLogger(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.TimingLogger.staticClass, global::android.util.TimingLogger._TimingLogger8330, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.TimingLogger.staticClass = @__class;
			global::android.util.TimingLogger._reset8326 = @__env.GetMethodID(global::android.util.TimingLogger.staticClass, "reset", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.util.TimingLogger._reset8327 = @__env.GetMethodID(global::android.util.TimingLogger.staticClass, "reset", "()V");
			global::android.util.TimingLogger._addSplit8328 = @__env.GetMethodID(global::android.util.TimingLogger.staticClass, "addSplit", "(Ljava/lang/String;)V");
			global::android.util.TimingLogger._dumpToLog8329 = @__env.GetMethodID(global::android.util.TimingLogger.staticClass, "dumpToLog", "()V");
			global::android.util.TimingLogger._TimingLogger8330 = @__env.GetMethodID(global::android.util.TimingLogger.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
