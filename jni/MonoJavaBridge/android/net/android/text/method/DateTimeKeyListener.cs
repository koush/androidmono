namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DateTimeKeyListener : android.text.method.NumberKeyListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DateTimeKeyListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.DateTimeKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.method.DateTimeKeyListener(@__env); 
			} 
		} 
		protected DateTimeKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6778; 
		public static android.text.method.DateTimeKeyListener getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.DateTimeKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.DateTimeKeyListener.staticClass, _getInstance6778)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputType6779; 
		public override int getInputType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.DateTimeKeyListener)) 
				return @__env.CallIntMethod(this, _getInputType6779); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.method.DateTimeKeyListener.staticClass, _getInputType6779); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAcceptedChars6780; 
		protected override char[] getAcceptedChars() 
		{ 
			if (GetType() == typeof(android.text.method.DateTimeKeyListener)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getAcceptedChars6780)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.method.DateTimeKeyListener.staticClass, _getAcceptedChars6780)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DateTimeKeyListener6781; 
		public DateTimeKeyListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.DateTimeKeyListener.staticClass, _DateTimeKeyListener6781, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CHARACTERS6782; 
		public static char[] CHARACTERS
		{ 
			get 
			{ 
				return default(char[]); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.DateTimeKeyListener.staticClass = @__class; 
			global::android.text.method.DateTimeKeyListener._getInstance6778 = @__env.GetStaticMethodID(global::android.text.method.DateTimeKeyListener.staticClass, "getInstance", "()Landroid/text/method/DateTimeKeyListener;"); 
			global::android.text.method.DateTimeKeyListener._getInputType6779 = @__env.GetMethodID(global::android.text.method.DateTimeKeyListener.staticClass, "getInputType", "()I"); 
			global::android.text.method.DateTimeKeyListener._getAcceptedChars6780 = @__env.GetMethodID(global::android.text.method.DateTimeKeyListener.staticClass, "getAcceptedChars", "()[C"); 
			global::android.text.method.DateTimeKeyListener._DateTimeKeyListener6781 = @__env.GetMethodID(global::android.text.method.DateTimeKeyListener.staticClass, "<init>", "()V"); 
		} 
	} 
} 
