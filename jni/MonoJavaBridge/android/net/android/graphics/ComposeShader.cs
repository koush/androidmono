namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ComposeShader : android.graphics.Shader
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ComposeShader() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.ComposeShader), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.ComposeShader(@__env); 
			} 
		} 
		protected ComposeShader(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ComposeShader2929; 
		public ComposeShader(android.graphics.Shader arg0, android.graphics.Shader arg1, android.graphics.Xfermode arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.ComposeShader.staticClass, _ComposeShader2929, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ComposeShader2930; 
		public ComposeShader(android.graphics.Shader arg0, android.graphics.Shader arg1, android.graphics.PorterDuff.Mode arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.ComposeShader.staticClass, _ComposeShader2930, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.ComposeShader.staticClass = @__class; 
			global::android.graphics.ComposeShader._ComposeShader2929 = @__env.GetMethodID(global::android.graphics.ComposeShader.staticClass, "<init>", "(Landroid/graphics/Shader;Landroid/graphics/Shader;Landroid/graphics/Xfermode;)V"); 
			global::android.graphics.ComposeShader._ComposeShader2930 = @__env.GetMethodID(global::android.graphics.ComposeShader.staticClass, "<init>", "(Landroid/graphics/Shader;Landroid/graphics/Shader;Landroid/graphics/PorterDuff$Mode;)V"); 
		} 
	} 
} 
