namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.method.NumberKeyListener_))]
	public abstract partial class NumberKeyListener : android.text.method.BaseKeyListener, InputFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NumberKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _lookup13350;
		protected virtual int lookup(android.view.KeyEvent arg0, android.text.Spannable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.NumberKeyListener.staticClass, "lookup", "(Landroid/view/KeyEvent;Landroid/text/Spannable;)I", ref global::android.text.method.NumberKeyListener._lookup13350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ok13351;
		protected static bool ok(char[] arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.NumberKeyListener._ok13351.native == global::System.IntPtr.Zero)
				global::android.text.method.NumberKeyListener._ok13351 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.NumberKeyListener.staticClass, "ok", "([CC)Z");
			return @__env.CallStaticBooleanMethod(android.text.method.NumberKeyListener.staticClass, global::android.text.method.NumberKeyListener._ok13351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _filter13352;
		public virtual global::java.lang.CharSequence filter(java.lang.CharSequence arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.method.NumberKeyListener.staticClass, "filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", ref global::android.text.method.NumberKeyListener._filter13352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5)) as java.lang.CharSequence;
		}
		public java.lang.CharSequence filter(string arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5)
		{
			return filter((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown13353;
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.NumberKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.NumberKeyListener._onKeyDown13353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars13354;
		protected abstract char[] getAcceptedChars();
		internal static global::MonoJavaBridge.MethodId _NumberKeyListener13355;
		public NumberKeyListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.NumberKeyListener._NumberKeyListener13355.native == global::System.IntPtr.Zero)
				global::android.text.method.NumberKeyListener._NumberKeyListener13355 = @__env.GetMethodIDNoThrow(global::android.text.method.NumberKeyListener.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.NumberKeyListener.staticClass, global::android.text.method.NumberKeyListener._NumberKeyListener13355);
			Init(@__env, handle);
		}
		static NumberKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.NumberKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/NumberKeyListener"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.method.NumberKeyListener))]
	internal sealed partial class NumberKeyListener_ : android.text.method.NumberKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NumberKeyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars13356;
		protected override char[] getAcceptedChars()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.text.method.NumberKeyListener_.staticClass, "getAcceptedChars", "()[C", ref global::android.text.method.NumberKeyListener_._getAcceptedChars13356) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13357;
		public override int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.NumberKeyListener_.staticClass, "getInputType", "()I", ref global::android.text.method.NumberKeyListener_._getInputType13357);
		}
		static NumberKeyListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.NumberKeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/NumberKeyListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
