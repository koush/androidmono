namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.method.ReplacementTransformationMethod_))]
	public abstract partial class ReplacementTransformationMethod : java.lang.Object, TransformationMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ReplacementTransformationMethod(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged13370;
		public virtual void onFocusChanged(android.view.View arg0, java.lang.CharSequence arg1, bool arg2, int arg3, android.graphics.Rect arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.ReplacementTransformationMethod.staticClass, "onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V", ref global::android.text.method.ReplacementTransformationMethod._onFocusChanged13370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public void onFocusChanged(android.view.View arg0, string arg1, bool arg2, int arg3, android.graphics.Rect arg4)
		{
			onFocusChanged(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3, arg4);
		}
		internal static global::MonoJavaBridge.MethodId _getTransformation13371;
		public virtual global::java.lang.CharSequence getTransformation(java.lang.CharSequence arg0, android.view.View arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.method.ReplacementTransformationMethod.staticClass, "getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;", ref global::android.text.method.ReplacementTransformationMethod._getTransformation13371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		public java.lang.CharSequence getTransformation(string arg0, android.view.View arg1)
		{
			return getTransformation((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _getOriginal13372;
		protected abstract char[] getOriginal();
		internal static global::MonoJavaBridge.MethodId _getReplacement13373;
		protected abstract char[] getReplacement();
		internal static global::MonoJavaBridge.MethodId _ReplacementTransformationMethod13374;
		public ReplacementTransformationMethod() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.ReplacementTransformationMethod._ReplacementTransformationMethod13374.native == global::System.IntPtr.Zero)
				global::android.text.method.ReplacementTransformationMethod._ReplacementTransformationMethod13374 = @__env.GetMethodIDNoThrow(global::android.text.method.ReplacementTransformationMethod.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.ReplacementTransformationMethod.staticClass, global::android.text.method.ReplacementTransformationMethod._ReplacementTransformationMethod13374);
			Init(@__env, handle);
		}
		static ReplacementTransformationMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.ReplacementTransformationMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/ReplacementTransformationMethod"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.method.ReplacementTransformationMethod))]
	internal sealed partial class ReplacementTransformationMethod_ : android.text.method.ReplacementTransformationMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ReplacementTransformationMethod_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOriginal13375;
		protected override char[] getOriginal()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.text.method.ReplacementTransformationMethod_.staticClass, "getOriginal", "()[C", ref global::android.text.method.ReplacementTransformationMethod_._getOriginal13375) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _getReplacement13376;
		protected override char[] getReplacement()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.text.method.ReplacementTransformationMethod_.staticClass, "getReplacement", "()[C", ref global::android.text.method.ReplacementTransformationMethod_._getReplacement13376) as char[];
		}
		static ReplacementTransformationMethod_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.ReplacementTransformationMethod_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/ReplacementTransformationMethod"));
		}
		internal static void InitJNI()
		{
		}
	}
}
