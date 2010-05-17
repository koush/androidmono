namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PorterDuffXfermode : android.graphics.Xfermode
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PorterDuffXfermode() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.PorterDuffXfermode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.PorterDuffXfermode(@__env); 
			} 
		} 
		protected PorterDuffXfermode(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PorterDuffXfermode3078; 
		public PorterDuffXfermode(android.graphics.PorterDuff.Mode arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.PorterDuffXfermode.staticClass, _PorterDuffXfermode3078, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.PorterDuffXfermode.staticClass = @__class; 
			global::android.graphics.PorterDuffXfermode._PorterDuffXfermode3078 = @__env.GetMethodID(global::android.graphics.PorterDuffXfermode.staticClass, "<init>", "(Landroid/graphics/PorterDuff$Mode;)V"); 
		} 
	} 
} 
