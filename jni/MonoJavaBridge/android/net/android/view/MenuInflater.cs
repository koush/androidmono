namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MenuInflater : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static MenuInflater() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.MenuInflater), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.MenuInflater(@__env); 
			} 
		} 
		protected MenuInflater(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate7902; 
		public virtual void inflate(int arg0, android.view.Menu arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MenuInflater)) 
				@__env.CallVoidMethod(this, global::android.view.MenuInflater._inflate7902, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MenuInflater.staticClass, global::android.view.MenuInflater._inflate7902, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MenuInflater7903; 
		public MenuInflater(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.MenuInflater.staticClass, global::android.view.MenuInflater._MenuInflater7903, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.MenuInflater.staticClass = @__class; 
			global::android.view.MenuInflater._inflate7902 = @__env.GetMethodID(global::android.view.MenuInflater.staticClass, "inflate", "(ILandroid/view/Menu;)V"); 
			global::android.view.MenuInflater._MenuInflater7903 = @__env.GetMethodID(global::android.view.MenuInflater.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
