namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SumPathEffect : android.graphics.PathEffect
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SumPathEffect() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.SumPathEffect), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.SumPathEffect(@__env); 
			} 
		} 
		protected SumPathEffect(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SumPathEffect3414; 
		public SumPathEffect(android.graphics.PathEffect arg0, android.graphics.PathEffect arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.SumPathEffect.staticClass, _SumPathEffect3414, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.SumPathEffect.staticClass = @__class; 
			global::android.graphics.SumPathEffect._SumPathEffect3414 = @__env.GetMethodID(global::android.graphics.SumPathEffect.staticClass, "<init>", "(Landroid/graphics/PathEffect;Landroid/graphics/PathEffect;)V"); 
		} 
	} 
} 
