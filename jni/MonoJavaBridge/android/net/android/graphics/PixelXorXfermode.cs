namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PixelXorXfermode : android.graphics.Xfermode
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PixelXorXfermode() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.PixelXorXfermode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.PixelXorXfermode(@__env); 
			} 
		} 
		protected PixelXorXfermode(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PixelXorXfermode3233; 
		public PixelXorXfermode(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.PixelXorXfermode.staticClass, global::android.graphics.PixelXorXfermode._PixelXorXfermode3233, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.PixelXorXfermode.staticClass = @__class; 
			global::android.graphics.PixelXorXfermode._PixelXorXfermode3233 = @__env.GetMethodID(global::android.graphics.PixelXorXfermode.staticClass, "<init>", "(I)V"); 
		} 
	} 
} 
