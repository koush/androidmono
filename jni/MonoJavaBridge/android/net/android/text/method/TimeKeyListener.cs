namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TimeKeyListener : android.text.method.NumberKeyListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TimeKeyListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.TimeKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.method.TimeKeyListener(@__env); 
			} 
		} 
		protected TimeKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6898; 
		public static android.text.method.TimeKeyListener getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.TimeKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.TimeKeyListener.staticClass, _getInstance6898)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputType6899; 
		public override int getInputType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.TimeKeyListener)) 
				return @__env.CallIntMethod(this, _getInputType6899); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.method.TimeKeyListener.staticClass, _getInputType6899); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAcceptedChars6900; 
		protected override char[] getAcceptedChars() 
		{ 
			if (GetType() == typeof(android.text.method.TimeKeyListener)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getAcceptedChars6900)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.method.TimeKeyListener.staticClass, _getAcceptedChars6900)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TimeKeyListener6901; 
		public TimeKeyListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.TimeKeyListener.staticClass, _TimeKeyListener6901, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CHARACTERS6902; 
		public static char[] CHARACTERS
		{ 
			get 
			{ 
				return default(char[]); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.TimeKeyListener.staticClass = @__class; 
			global::android.text.method.TimeKeyListener._getInstance6898 = @__env.GetStaticMethodID(global::android.text.method.TimeKeyListener.staticClass, "getInstance", "()Landroid/text/method/TimeKeyListener;"); 
			global::android.text.method.TimeKeyListener._getInputType6899 = @__env.GetMethodID(global::android.text.method.TimeKeyListener.staticClass, "getInputType", "()I"); 
			global::android.text.method.TimeKeyListener._getAcceptedChars6900 = @__env.GetMethodID(global::android.text.method.TimeKeyListener.staticClass, "getAcceptedChars", "()[C"); 
			global::android.text.method.TimeKeyListener._TimeKeyListener6901 = @__env.GetMethodID(global::android.text.method.TimeKeyListener.staticClass, "<init>", "()V"); 
		} 
	} 
} 
