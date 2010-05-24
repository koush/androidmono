namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Editable_Factory : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Editable_Factory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.Editable_Factory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.Editable_Factory(@__env); 
			} 
		} 
		protected Editable_Factory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6745; 
		public static android.text.Editable_Factory getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Editable_Factory>(@__env, @__env.CallStaticObjectMethodPtr(android.text.Editable_Factory.staticClass, _getInstance6745)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newEditable6746; 
		public virtual android.text.Editable newEditable(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Editable_Factory)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, _newEditable6746, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.Editable_Factory.staticClass, _newEditable6746, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Editable_Factory6747; 
		public Editable_Factory()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.Editable_Factory.staticClass, _Editable_Factory6747, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.Editable_Factory.staticClass = @__class; 
			global::android.text.Editable_Factory._getInstance6745 = @__env.GetStaticMethodID(global::android.text.Editable_Factory.staticClass, "getInstance", "()Landroid/text/Editable$Factory;"); 
			global::android.text.Editable_Factory._newEditable6746 = @__env.GetMethodID(global::android.text.Editable_Factory.staticClass, "newEditable", "(Ljava/lang/CharSequence;)Landroid/text/Editable;"); 
			global::android.text.Editable_Factory._Editable_Factory6747 = @__env.GetMethodID(global::android.text.Editable_Factory.staticClass, "<init>", "()V"); 
		} 
	} 
} 
