namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DashPathEffect : android.graphics.PathEffect
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DashPathEffect() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.DashPathEffect), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.DashPathEffect(@__env); 
			} 
		} 
		protected DashPathEffect(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DashPathEffect2732; 
		public DashPathEffect(float[] arg0, float arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.DashPathEffect.staticClass, _DashPathEffect2732, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.DashPathEffect.staticClass = @__class; 
			global::android.graphics.DashPathEffect._DashPathEffect2732 = @__env.GetMethodID(global::android.graphics.DashPathEffect.staticClass, "<init>", "([FF)V"); 
		} 
	} 
} 
