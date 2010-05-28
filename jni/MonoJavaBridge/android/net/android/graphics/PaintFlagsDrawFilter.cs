namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PaintFlagsDrawFilter : android.graphics.DrawFilter
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PaintFlagsDrawFilter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.PaintFlagsDrawFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.PaintFlagsDrawFilter(@__env); 
			} 
		} 
		protected PaintFlagsDrawFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PaintFlagsDrawFilter3153; 
		public PaintFlagsDrawFilter(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.PaintFlagsDrawFilter.staticClass, global::android.graphics.PaintFlagsDrawFilter._PaintFlagsDrawFilter3153, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.PaintFlagsDrawFilter.staticClass = @__class; 
			global::android.graphics.PaintFlagsDrawFilter._PaintFlagsDrawFilter3153 = @__env.GetMethodID(global::android.graphics.PaintFlagsDrawFilter.staticClass, "<init>", "(II)V"); 
		} 
	} 
} 
