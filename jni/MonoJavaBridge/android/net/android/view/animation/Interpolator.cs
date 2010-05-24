namespace android.view.animation 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Interpolator 
	{ 
		float getInterpolation(float arg0); 
	} 

	public partial class Interpolator_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __Interpolator.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __Interpolator : java.lang.Object, Interpolator
	{ 
		internal static global::java.lang.Class staticClass; 
		static __Interpolator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.animation.__Interpolator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.animation.__Interpolator(@__env); 
			} 
		} 
		internal __Interpolator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolation8962; 
		 float android.view.animation.Interpolator.getInterpolation(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.__Interpolator)) 
				return @__env.CallFloatMethod(this, _getInterpolation8962, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.animation.__Interpolator.staticClass, _getInterpolation8962, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.animation.__Interpolator.staticClass = @__class; 
			global::android.view.animation.__Interpolator._getInterpolation8962 = @__env.GetMethodID(global::android.view.animation.__Interpolator.staticClass, "android.view.animation.Interpolator.getInterpolation", "(F)F"); 
		} 
	} 
} 
