namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DiscretePathEffect : android.graphics.PathEffect
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DiscretePathEffect() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.DiscretePathEffect), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.DiscretePathEffect(@__env); 
			} 
		} 
		protected DiscretePathEffect(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DiscretePathEffect2933; 
		public DiscretePathEffect(float arg0, float arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.DiscretePathEffect.staticClass, global::android.graphics.DiscretePathEffect._DiscretePathEffect2933, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.DiscretePathEffect.staticClass = @__class; 
			global::android.graphics.DiscretePathEffect._DiscretePathEffect2933 = @__env.GetMethodID(global::android.graphics.DiscretePathEffect.staticClass, "<init>", "(FF)V"); 
		} 
	} 
} 
