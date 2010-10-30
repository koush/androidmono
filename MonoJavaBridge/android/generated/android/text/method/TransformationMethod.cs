namespace android.text.method
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.method.TransformationMethod_))]
	public partial interface TransformationMethod  : global::MonoJavaBridge.IJavaObject 
	{
		void onFocusChanged(android.view.View arg0, java.lang.CharSequence arg1, bool arg2, int arg3, android.graphics.Rect arg4);
		global::java.lang.CharSequence getTransformation(java.lang.CharSequence arg0, android.view.View arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.method.TransformationMethod))]
	internal sealed partial class TransformationMethod_ : java.lang.Object, TransformationMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TransformationMethod_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged13423;
		void android.text.method.TransformationMethod.onFocusChanged(android.view.View arg0, java.lang.CharSequence arg1, bool arg2, int arg3, android.graphics.Rect arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.TransformationMethod_.staticClass, "onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V", ref global::android.text.method.TransformationMethod_._onFocusChanged13423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getTransformation13424;
		global::java.lang.CharSequence android.text.method.TransformationMethod.getTransformation(java.lang.CharSequence arg0, android.view.View arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.method.TransformationMethod_.staticClass, "getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;", ref global::android.text.method.TransformationMethod_._getTransformation13424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		static TransformationMethod_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.TransformationMethod_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/TransformationMethod"));
		}
		internal static void InitJNI()
		{
		}
	}
}
