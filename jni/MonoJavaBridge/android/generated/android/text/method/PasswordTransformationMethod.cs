namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PasswordTransformationMethod : java.lang.Object, TransformationMethod, TextWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PasswordTransformationMethod()
		{
			InitJNI();
		}
		protected PasswordTransformationMethod(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.text.method.PasswordTransformationMethod Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance13358;
		public static global::android.text.method.PasswordTransformationMethod getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._getInstance13358)) as android.text.method.PasswordTransformationMethod;
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged13359;
		public virtual void onFocusChanged(android.view.View arg0, java.lang.CharSequence arg1, bool arg2, int arg3, android.graphics.Rect arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.PasswordTransformationMethod._onFocusChanged13359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._onFocusChanged13359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public void onFocusChanged(android.view.View arg0, string arg1, bool arg2, int arg3, android.graphics.Rect arg4)
		{
			onFocusChanged(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3, arg4);
		}
		internal static global::MonoJavaBridge.MethodId _onTextChanged13360;
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.PasswordTransformationMethod._onTextChanged13360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._onTextChanged13360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _beforeTextChanged13361;
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.PasswordTransformationMethod._beforeTextChanged13361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._beforeTextChanged13361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void beforeTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			beforeTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _afterTextChanged13362;
		public virtual void afterTextChanged(android.text.Editable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.PasswordTransformationMethod._afterTextChanged13362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._afterTextChanged13362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTransformation13363;
		public virtual global::java.lang.CharSequence getTransformation(java.lang.CharSequence arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.PasswordTransformationMethod._getTransformation13363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._getTransformation13363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		public java.lang.CharSequence getTransformation(string arg0, android.view.View arg1)
		{
			return getTransformation((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _PasswordTransformationMethod13364;
		public PasswordTransformationMethod()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._PasswordTransformationMethod13364);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.PasswordTransformationMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/PasswordTransformationMethod"));
			global::android.text.method.PasswordTransformationMethod._getInstance13358 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.PasswordTransformationMethod.staticClass, "getInstance", "()Landroid/text/method/PasswordTransformationMethod;");
			global::android.text.method.PasswordTransformationMethod._onFocusChanged13359 = @__env.GetMethodIDNoThrow(global::android.text.method.PasswordTransformationMethod.staticClass, "onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V");
			global::android.text.method.PasswordTransformationMethod._onTextChanged13360 = @__env.GetMethodIDNoThrow(global::android.text.method.PasswordTransformationMethod.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.text.method.PasswordTransformationMethod._beforeTextChanged13361 = @__env.GetMethodIDNoThrow(global::android.text.method.PasswordTransformationMethod.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.text.method.PasswordTransformationMethod._afterTextChanged13362 = @__env.GetMethodIDNoThrow(global::android.text.method.PasswordTransformationMethod.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V");
			global::android.text.method.PasswordTransformationMethod._getTransformation13363 = @__env.GetMethodIDNoThrow(global::android.text.method.PasswordTransformationMethod.staticClass, "getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;");
			global::android.text.method.PasswordTransformationMethod._PasswordTransformationMethod13364 = @__env.GetMethodIDNoThrow(global::android.text.method.PasswordTransformationMethod.staticClass, "<init>", "()V");
		}
	}
}
