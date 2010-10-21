namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.method.BaseKeyListener_))]
	public abstract partial class BaseKeyListener : android.text.method.MetaKeyKeyListener, KeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BaseKeyListener()
		{
			InitJNI();
		}
		protected BaseKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13194;
		public abstract int getInputType();
		internal static global::MonoJavaBridge.MethodId _onKeyDown13195;
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.BaseKeyListener._onKeyDown13195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.BaseKeyListener.staticClass, global::android.text.method.BaseKeyListener._onKeyDown13195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyOther13196;
		public virtual bool onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.BaseKeyListener._onKeyOther13196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.BaseKeyListener.staticClass, global::android.text.method.BaseKeyListener._onKeyOther13196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _backspace13197;
		public virtual bool backspace(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.BaseKeyListener._backspace13197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.BaseKeyListener.staticClass, global::android.text.method.BaseKeyListener._backspace13197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _BaseKeyListener13198;
		public BaseKeyListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.BaseKeyListener.staticClass, global::android.text.method.BaseKeyListener._BaseKeyListener13198);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.BaseKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/BaseKeyListener"));
			global::android.text.method.BaseKeyListener._getInputType13194 = @__env.GetMethodIDNoThrow(global::android.text.method.BaseKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.BaseKeyListener._onKeyDown13195 = @__env.GetMethodIDNoThrow(global::android.text.method.BaseKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.BaseKeyListener._onKeyOther13196 = @__env.GetMethodIDNoThrow(global::android.text.method.BaseKeyListener.staticClass, "onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z");
			global::android.text.method.BaseKeyListener._backspace13197 = @__env.GetMethodIDNoThrow(global::android.text.method.BaseKeyListener.staticClass, "backspace", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.BaseKeyListener._BaseKeyListener13198 = @__env.GetMethodIDNoThrow(global::android.text.method.BaseKeyListener.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.method.BaseKeyListener))]
	public sealed partial class BaseKeyListener_ : android.text.method.BaseKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BaseKeyListener_()
		{
			InitJNI();
		}
		internal BaseKeyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13199;
		public override int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.BaseKeyListener_._getInputType13199);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.BaseKeyListener_.staticClass, global::android.text.method.BaseKeyListener_._getInputType13199);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.BaseKeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/BaseKeyListener"));
			global::android.text.method.BaseKeyListener_._getInputType13199 = @__env.GetMethodIDNoThrow(global::android.text.method.BaseKeyListener_.staticClass, "getInputType", "()I");
		}
	}
}
