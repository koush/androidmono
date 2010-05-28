namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DebugUtils : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static DebugUtils() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.DebugUtils), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.util.DebugUtils(@__env); 
			} 
		} 
		protected DebugUtils(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isObjectSelected7532; 
		public static bool isObjectSelected(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.util.DebugUtils.staticClass, global::android.util.DebugUtils._isObjectSelected7532, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DebugUtils7533; 
		public DebugUtils()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.DebugUtils.staticClass, global::android.util.DebugUtils._DebugUtils7533, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.DebugUtils.staticClass = @__class; 
			global::android.util.DebugUtils._isObjectSelected7532 = @__env.GetStaticMethodID(global::android.util.DebugUtils.staticClass, "isObjectSelected", "(Ljava/lang/Object;)Z"); 
			global::android.util.DebugUtils._DebugUtils7533 = @__env.GetMethodID(global::android.util.DebugUtils.staticClass, "<init>", "()V"); 
		} 
	} 
} 
