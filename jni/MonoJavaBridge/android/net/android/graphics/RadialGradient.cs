namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RadialGradient : android.graphics.Shader
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RadialGradient() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.RadialGradient), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.RadialGradient(@__env); 
			} 
		} 
		protected RadialGradient(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RadialGradient3079; 
		public RadialGradient(float arg0, float arg1, float arg2, int[] arg3, float[] arg4, android.graphics.Shader.TileMode arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.RadialGradient.staticClass, _RadialGradient3079, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RadialGradient3080; 
		public RadialGradient(float arg0, float arg1, float arg2, int arg3, int arg4, android.graphics.Shader.TileMode arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.RadialGradient.staticClass, _RadialGradient3080, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.RadialGradient.staticClass = @__class; 
			global::android.graphics.RadialGradient._RadialGradient3079 = @__env.GetMethodID(global::android.graphics.RadialGradient.staticClass, "<init>", "(FFF[I[FLandroid/graphics/Shader$TileMode;)V"); 
			global::android.graphics.RadialGradient._RadialGradient3080 = @__env.GetMethodID(global::android.graphics.RadialGradient.staticClass, "<init>", "(FFFIILandroid/graphics/Shader$TileMode;)V"); 
		} 
	} 
} 
