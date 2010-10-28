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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.NumberKeyListener._lookup13350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.NumberKeyListener.staticClass, global::android.text.method.NumberKeyListener._lookup13350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ok13351;
		protected static bool ok(char[] arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.method.NumberKeyListener.staticClass, global::android.text.method.NumberKeyListener._ok13351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _filter13352;
		public virtual global::java.lang.CharSequence filter(java.lang.CharSequence arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.NumberKeyListener._filter13352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.NumberKeyListener.staticClass, global::android.text.method.NumberKeyListener._filter13352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.lang.CharSequence;
		}
		public java.lang.CharSequence filter(string arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5)
		{
			return filter((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown13353;
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.NumberKeyListener._onKeyDown13353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.NumberKeyListener.staticClass, global::android.text.method.NumberKeyListener._onKeyDown13353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars13354;
		protected abstract char[] getAcceptedChars();
		internal static global::MonoJavaBridge.MethodId _NumberKeyListener13355;
		public NumberKeyListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.NumberKeyListener.staticClass, global::android.text.method.NumberKeyListener._NumberKeyListener13355);
			Init(@__env, handle);
		}
		static NumberKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.NumberKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/NumberKeyListener"));
			global::android.text.method.NumberKeyListener._lookup13350 = @__env.GetMethodIDNoThrow(global::android.text.method.NumberKeyListener.staticClass, "lookup", "(Landroid/view/KeyEvent;Landroid/text/Spannable;)I");
			global::android.text.method.NumberKeyListener._ok13351 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.NumberKeyListener.staticClass, "ok", "([CC)Z");
			global::android.text.method.NumberKeyListener._filter13352 = @__env.GetMethodIDNoThrow(global::android.text.method.NumberKeyListener.staticClass, "filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;");
			global::android.text.method.NumberKeyListener._onKeyDown13353 = @__env.GetMethodIDNoThrow(global::android.text.method.NumberKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.NumberKeyListener._getAcceptedChars13354 = @__env.GetMethodIDNoThrow(global::android.text.method.NumberKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.NumberKeyListener._NumberKeyListener13355 = @__env.GetMethodIDNoThrow(global::android.text.method.NumberKeyListener.staticClass, "<init>", "()V");
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.NumberKeyListener_._getAcceptedChars13356)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.NumberKeyListener_.staticClass, global::android.text.method.NumberKeyListener_._getAcceptedChars13356)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13357;
		public override int getInputType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.NumberKeyListener_._getInputType13357);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.NumberKeyListener_.staticClass, global::android.text.method.NumberKeyListener_._getInputType13357);
		}
		static NumberKeyListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.NumberKeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/NumberKeyListener"));
			global::android.text.method.NumberKeyListener_._getAcceptedChars13356 = @__env.GetMethodIDNoThrow(global::android.text.method.NumberKeyListener_.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.NumberKeyListener_._getInputType13357 = @__env.GetMethodIDNoThrow(global::android.text.method.NumberKeyListener_.staticClass, "getInputType", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}
