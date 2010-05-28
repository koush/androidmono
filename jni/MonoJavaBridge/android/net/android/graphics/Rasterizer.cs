namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Rasterizer : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Rasterizer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Rasterizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.Rasterizer(@__env); 
			} 
		} 
		protected Rasterizer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Rasterizer3281; 
		public Rasterizer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Rasterizer.staticClass, global::android.graphics.Rasterizer._Rasterizer3281, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Rasterizer.staticClass = @__class; 
			global::android.graphics.Rasterizer._Rasterizer3281 = @__env.GetMethodID(global::android.graphics.Rasterizer.staticClass, "<init>", "()V"); 
		} 
	} 
} 
