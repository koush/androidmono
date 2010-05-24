namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MaskFilter : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static MaskFilter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.MaskFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.MaskFilter(@__env); 
			} 
		} 
		protected MaskFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MaskFilter2958; 
		public MaskFilter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.MaskFilter.staticClass, _MaskFilter2958, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.MaskFilter.staticClass = @__class; 
			global::android.graphics.MaskFilter._MaskFilter2958 = @__env.GetMethodID(global::android.graphics.MaskFilter.staticClass, "<init>", "()V"); 
		} 
	} 
} 
