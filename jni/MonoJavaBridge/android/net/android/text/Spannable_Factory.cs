namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Spannable_Factory : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Spannable_Factory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.Spannable_Factory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6885; 
		public static global::android.text.Spannable_Factory getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Spannable_Factory>(@__env, @__env.CallStaticObjectMethodPtr(android.text.Spannable_Factory.staticClass, global::android.text.Spannable_Factory._getInstance6885)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newSpannable6886; 
		public virtual global::android.text.Spannable newSpannable(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Spannable>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.Spannable_Factory._newSpannable6886, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Spannable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.Spannable_Factory.staticClass, global::android.text.Spannable_Factory._newSpannable6886, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Spannable_Factory6887; 
		public Spannable_Factory()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.Spannable_Factory.staticClass, global::android.text.Spannable_Factory._Spannable_Factory6887, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.Spannable_Factory.staticClass = @__class; 
			global::android.text.Spannable_Factory._getInstance6885 = @__env.GetStaticMethodID(global::android.text.Spannable_Factory.staticClass, "getInstance", "()Landroid/text/Spannable$Factory;"); 
			global::android.text.Spannable_Factory._newSpannable6886 = @__env.GetMethodID(global::android.text.Spannable_Factory.staticClass, "newSpannable", "(Ljava/lang/CharSequence;)Landroid/text/Spannable;"); 
			global::android.text.Spannable_Factory._Spannable_Factory6887 = @__env.GetMethodID(global::android.text.Spannable_Factory.staticClass, "<init>", "()V"); 
		} 
	} 
	public static class Spannable_FactoryExtensionMethods 
	{ 
		public static android.text.Spannable newSpannable(this global::android.text.Spannable_Factory __this, string arg0) 
		{ 
			return __this.newSpannable((global::java.lang.String)arg0); 
		} 
	} 
} 
