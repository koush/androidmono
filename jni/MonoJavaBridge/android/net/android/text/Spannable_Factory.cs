namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Spannable_Factory : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Spannable_Factory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.Spannable_Factory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.Spannable_Factory(@__env); 
			} 
		} 
		protected Spannable_Factory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6556; 
		public static android.text.Spannable_Factory getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Spannable_Factory>(@__env, @__env.CallStaticObjectMethodPtr(android.text.Spannable_Factory.staticClass, _getInstance6556)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newSpannable6557; 
		public virtual android.text.Spannable newSpannable(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Spannable_Factory)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Spannable>(@__env, @__env.CallObjectMethodPtr(this, _newSpannable6557, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Spannable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.Spannable_Factory.staticClass, _newSpannable6557, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Spannable_Factory6558; 
		public Spannable_Factory()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.Spannable_Factory.staticClass, _Spannable_Factory6558, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.Spannable_Factory.staticClass = @__class; 
			global::android.text.Spannable_Factory._getInstance6556 = @__env.GetStaticMethodID(global::android.text.Spannable_Factory.staticClass, "getInstance", "()Landroid/text/Spannable$Factory;"); 
			global::android.text.Spannable_Factory._newSpannable6557 = @__env.GetMethodID(global::android.text.Spannable_Factory.staticClass, "newSpannable", "(Ljava/lang/CharSequence;)Landroid/text/Spannable;"); 
			global::android.text.Spannable_Factory._Spannable_Factory6558 = @__env.GetMethodID(global::android.text.Spannable_Factory.staticClass, "<init>", "()V"); 
		} 
	} 
} 
