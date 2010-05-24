namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MutableContextWrapper : android.content.ContextWrapper
	{ 
		internal new static global::java.lang.Class staticClass; 
		static MutableContextWrapper() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.MutableContextWrapper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.MutableContextWrapper(@__env); 
			} 
		} 
		protected MutableContextWrapper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBaseContext1473; 
		public virtual void setBaseContext(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.MutableContextWrapper)) 
				@__env.CallVoidMethod(this, _setBaseContext1473, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.MutableContextWrapper.staticClass, _setBaseContext1473, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MutableContextWrapper1474; 
		public MutableContextWrapper(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.MutableContextWrapper.staticClass, _MutableContextWrapper1474, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.MutableContextWrapper.staticClass = @__class; 
			global::android.content.MutableContextWrapper._setBaseContext1473 = @__env.GetMethodID(global::android.content.MutableContextWrapper.staticClass, "setBaseContext", "(Landroid/content/Context;)V"); 
			global::android.content.MutableContextWrapper._MutableContextWrapper1474 = @__env.GetMethodID(global::android.content.MutableContextWrapper.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
