namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TimeUtils : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static TimeUtils() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.util.TimeUtils), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.util.TimeUtils(@__env); 
			} 
		} 
		protected TimeUtils(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimeZone7246; 
		public static java.util.TimeZone getTimeZone(int arg0, bool arg1, long arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallStaticObjectMethodPtr(android.util.TimeUtils.staticClass, _getTimeZone7246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimeZoneDatabaseVersion7247; 
		public static java.lang.String getTimeZoneDatabaseVersion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.util.TimeUtils.staticClass, _getTimeZoneDatabaseVersion7247)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TimeUtils7248; 
		public TimeUtils()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.TimeUtils.staticClass, _TimeUtils7248, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.TimeUtils.staticClass = @__class; 
			global::android.util.TimeUtils._getTimeZone7246 = @__env.GetStaticMethodID(global::android.util.TimeUtils.staticClass, "getTimeZone", "(IZJLjava/lang/String;)Ljava/util/TimeZone;"); 
			global::android.util.TimeUtils._getTimeZoneDatabaseVersion7247 = @__env.GetStaticMethodID(global::android.util.TimeUtils.staticClass, "getTimeZoneDatabaseVersion", "()Ljava/lang/String;"); 
			global::android.util.TimeUtils._TimeUtils7248 = @__env.GetMethodID(global::android.util.TimeUtils.staticClass, "<init>", "()V"); 
		} 
	} 
} 
