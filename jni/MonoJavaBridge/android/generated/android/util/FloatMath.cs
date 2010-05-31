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
		internal static global::net.sf.jni4net.jni.MethodId _sin7551;
		public static float sin(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._sin7551, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cos7552;
		public static float cos(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._cos7552, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sqrt7553;
		public static float sqrt(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._sqrt7553, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ceil7554;
		public static float ceil(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._ceil7554, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _floor7555;
		public static float floor(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._floor7555, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.FloatMath.staticClass = @__class;
			global::android.util.FloatMath._sin7551 = @__env.GetStaticMethodID(global::android.util.FloatMath.staticClass, "sin", "(F)F");
			global::android.util.FloatMath._cos7552 = @__env.GetStaticMethodID(global::android.util.FloatMath.staticClass, "cos", "(F)F");
			global::android.util.FloatMath._sqrt7553 = @__env.GetStaticMethodID(global::android.util.FloatMath.staticClass, "sqrt", "(F)F");
			global::android.util.FloatMath._ceil7554 = @__env.GetStaticMethodID(global::android.util.FloatMath.staticClass, "ceil", "(F)F");
			global::android.util.FloatMath._floor7555 = @__env.GetStaticMethodID(global::android.util.FloatMath.staticClass, "floor", "(F)F");
		}
	}
}
