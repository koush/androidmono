namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LightingColorFilter : android.graphics.ColorFilter
	{ 
		internal new static global::java.lang.Class staticClass; 
		static LightingColorFilter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.LightingColorFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.LightingColorFilter(@__env); 
			} 
		} 
		protected LightingColorFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LightingColorFilter2955; 
		public LightingColorFilter(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.LightingColorFilter.staticClass, _LightingColorFilter2955, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.LightingColorFilter.staticClass = @__class; 
			global::android.graphics.LightingColorFilter._LightingColorFilter2955 = @__env.GetMethodID(global::android.graphics.LightingColorFilter.staticClass, "<init>", "(II)V"); 
		} 
	} 
} 
