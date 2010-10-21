namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DigitsKeyListener : android.text.method.NumberKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DigitsKeyListener()
		{
			InitJNI();
		}
		protected DigitsKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance13220;
		public static global::android.text.method.DigitsKeyListener getInstance(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._getInstance13220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.method.DigitsKeyListener;
		}
		public static global::android.text.method.DigitsKeyListener Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance13221;
		public static global::android.text.method.DigitsKeyListener getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._getInstance13221)) as android.text.method.DigitsKeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance13222;
		public static global::android.text.method.DigitsKeyListener getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._getInstance13222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.method.DigitsKeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _filter13223;
		public override global::java.lang.CharSequence filter(java.lang.CharSequence arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.DigitsKeyListener._filter13223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._filter13223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.lang.CharSequence;
		}
		public java.lang.CharSequence filter(string arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5)
		{
			return filter((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13224;
		public override int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.DigitsKeyListener._getInputType13224);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._getInputType13224);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars13225;
		protected override char[] getAcceptedChars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.DigitsKeyListener._getAcceptedChars13225)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._getAcceptedChars13225)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _DigitsKeyListener13226;
		public DigitsKeyListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._DigitsKeyListener13226);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DigitsKeyListener13227;
		public DigitsKeyListener(bool arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._DigitsKeyListener13227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.DigitsKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/DigitsKeyListener"));
			global::android.text.method.DigitsKeyListener._getInstance13220 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DigitsKeyListener.staticClass, "getInstance", "(ZZ)Landroid/text/method/DigitsKeyListener;");
			global::android.text.method.DigitsKeyListener._getInstance13221 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DigitsKeyListener.staticClass, "getInstance", "()Landroid/text/method/DigitsKeyListener;");
			global::android.text.method.DigitsKeyListener._getInstance13222 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DigitsKeyListener.staticClass, "getInstance", "(Ljava/lang/String;)Landroid/text/method/DigitsKeyListener;");
			global::android.text.method.DigitsKeyListener._filter13223 = @__env.GetMethodIDNoThrow(global::android.text.method.DigitsKeyListener.staticClass, "filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;");
			global::android.text.method.DigitsKeyListener._getInputType13224 = @__env.GetMethodIDNoThrow(global::android.text.method.DigitsKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.DigitsKeyListener._getAcceptedChars13225 = @__env.GetMethodIDNoThrow(global::android.text.method.DigitsKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.DigitsKeyListener._DigitsKeyListener13226 = @__env.GetMethodIDNoThrow(global::android.text.method.DigitsKeyListener.staticClass, "<init>", "()V");
			global::android.text.method.DigitsKeyListener._DigitsKeyListener13227 = @__env.GetMethodIDNoThrow(global::android.text.method.DigitsKeyListener.staticClass, "<init>", "(ZZ)V");
		}
	}
}
