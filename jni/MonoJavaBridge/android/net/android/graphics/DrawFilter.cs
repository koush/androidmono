namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DrawFilter : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static DrawFilter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.DrawFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.DrawFilter(@__env); 
			} 
		} 
		protected DrawFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DrawFilter2734; 
		public DrawFilter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.DrawFilter.staticClass, _DrawFilter2734, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.DrawFilter.staticClass = @__class; 
			global::android.graphics.DrawFilter._DrawFilter2734 = @__env.GetMethodID(global::android.graphics.DrawFilter.staticClass, "<init>", "()V"); 
		} 
	} 
} 
