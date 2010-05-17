namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DateKeyListener : android.text.method.NumberKeyListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DateKeyListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.DateKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.method.DateKeyListener(@__env); 
			} 
		} 
		protected DateKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6773; 
		public static android.text.method.DateKeyListener getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.DateKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.DateKeyListener.staticClass, _getInstance6773)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputType6774; 
		public override int getInputType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.DateKeyListener)) 
				return @__env.CallIntMethod(this, _getInputType6774); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.method.DateKeyListener.staticClass, _getInputType6774); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAcceptedChars6775; 
		protected override char[] getAcceptedChars() 
		{ 
			if (GetType() == typeof(android.text.method.DateKeyListener)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getAcceptedChars6775)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.method.DateKeyListener.staticClass, _getAcceptedChars6775)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DateKeyListener6776; 
		public DateKeyListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.DateKeyListener.staticClass, _DateKeyListener6776, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CHARACTERS6777; 
		public static char[] CHARACTERS
		{ 
			get 
			{ 
				return default(char[]); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.DateKeyListener.staticClass = @__class; 
			global::android.text.method.DateKeyListener._getInstance6773 = @__env.GetStaticMethodID(global::android.text.method.DateKeyListener.staticClass, "getInstance", "()Landroid/text/method/DateKeyListener;"); 
			global::android.text.method.DateKeyListener._getInputType6774 = @__env.GetMethodID(global::android.text.method.DateKeyListener.staticClass, "getInputType", "()I"); 
			global::android.text.method.DateKeyListener._getAcceptedChars6775 = @__env.GetMethodID(global::android.text.method.DateKeyListener.staticClass, "getAcceptedChars", "()[C"); 
			global::android.text.method.DateKeyListener._DateKeyListener6776 = @__env.GetMethodID(global::android.text.method.DateKeyListener.staticClass, "<init>", "()V"); 
		} 
	} 
} 
