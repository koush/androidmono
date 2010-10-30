namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.method.BaseKeyListener_))]
	public abstract partial class BaseKeyListener : android.text.method.MetaKeyKeyListener, KeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BaseKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13256;
		public abstract int getInputType();
		internal static global::MonoJavaBridge.MethodId _onKeyDown13257;
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.BaseKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.BaseKeyListener._onKeyDown13257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyOther13258;
		public virtual bool onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.BaseKeyListener.staticClass, "onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z", ref global::android.text.method.BaseKeyListener._onKeyOther13258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _backspace13259;
		public virtual bool backspace(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.BaseKeyListener.staticClass, "backspace", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.BaseKeyListener._backspace13259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _BaseKeyListener13260;
		public BaseKeyListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.BaseKeyListener._BaseKeyListener13260.native == global::System.IntPtr.Zero)
				global::android.text.method.BaseKeyListener._BaseKeyListener13260 = @__env.GetMethodIDNoThrow(global::android.text.method.BaseKeyListener.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.BaseKeyListener.staticClass, global::android.text.method.BaseKeyListener._BaseKeyListener13260);
			Init(@__env, handle);
		}
		static BaseKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.BaseKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/BaseKeyListener"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.method.BaseKeyListener))]
	internal sealed partial class BaseKeyListener_ : android.text.method.BaseKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BaseKeyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13261;
		public override int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.BaseKeyListener_.staticClass, "getInputType", "()I", ref global::android.text.method.BaseKeyListener_._getInputType13261);
		}
		static BaseKeyListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.BaseKeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/BaseKeyListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
