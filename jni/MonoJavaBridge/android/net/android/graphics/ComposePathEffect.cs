namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ComposePathEffect : android.graphics.PathEffect
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ComposePathEffect() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.ComposePathEffect), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.ComposePathEffect(@__env); 
			} 
		} 
		protected ComposePathEffect(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ComposePathEffect2728; 
		public ComposePathEffect(android.graphics.PathEffect arg0, android.graphics.PathEffect arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.ComposePathEffect.staticClass, _ComposePathEffect2728, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.ComposePathEffect.staticClass = @__class; 
			global::android.graphics.ComposePathEffect._ComposePathEffect2728 = @__env.GetMethodID(global::android.graphics.ComposePathEffect.staticClass, "<init>", "(Landroid/graphics/PathEffect;Landroid/graphics/PathEffect;)V"); 
		} 
	} 
} 
