namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class FloatMath : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static FloatMath()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.FloatMath), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.FloatMath(@__env);
			}
		}
		protected FloatMath(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _sin8214;
		public static float sin(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._sin8214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cos8215;
		public static float cos(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._cos8215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sqrt8216;
		public static float sqrt(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._sqrt8216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ceil8217;
		public static float ceil(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._ceil8217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _floor8218;
		public static float floor(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._floor8218, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.FloatMath.staticClass = @__class;
			global::android.util.FloatMath._sin8214 = @__env.GetStaticMethodID(global::android.util.FloatMath.staticClass, "sin", "(F)F");
			global::android.util.FloatMath._cos8215 = @__env.GetStaticMethodID(global::android.util.FloatMath.staticClass, "cos", "(F)F");
			global::android.util.FloatMath._sqrt8216 = @__env.GetStaticMethodID(global::android.util.FloatMath.staticClass, "sqrt", "(F)F");
			global::android.util.FloatMath._ceil8217 = @__env.GetStaticMethodID(global::android.util.FloatMath.staticClass, "ceil", "(F)F");
			global::android.util.FloatMath._floor8218 = @__env.GetStaticMethodID(global::android.util.FloatMath.staticClass, "floor", "(F)F");
		}
	}
}
