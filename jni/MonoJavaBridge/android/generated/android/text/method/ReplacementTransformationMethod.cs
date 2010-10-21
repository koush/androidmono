namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.method.ReplacementTransformationMethod_))]
	public abstract partial class ReplacementTransformationMethod : java.lang.Object, TransformationMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ReplacementTransformationMethod()
		{
			InitJNI();
		}
		protected ReplacementTransformationMethod(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged13308;
		public virtual void onFocusChanged(android.view.View arg0, java.lang.CharSequence arg1, bool arg2, int arg3, android.graphics.Rect arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.ReplacementTransformationMethod._onFocusChanged13308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.ReplacementTransformationMethod.staticClass, global::android.text.method.ReplacementTransformationMethod._onFocusChanged13308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public void onFocusChanged(android.view.View arg0, string arg1, bool arg2, int arg3, android.graphics.Rect arg4)
		{
			onFocusChanged(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3, arg4);
		}
		internal static global::MonoJavaBridge.MethodId _getTransformation13309;
		public virtual global::java.lang.CharSequence getTransformation(java.lang.CharSequence arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.ReplacementTransformationMethod._getTransformation13309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.ReplacementTransformationMethod.staticClass, global::android.text.method.ReplacementTransformationMethod._getTransformation13309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		public java.lang.CharSequence getTransformation(string arg0, android.view.View arg1)
		{
			return getTransformation((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _getOriginal13310;
		protected abstract char[] getOriginal();
		internal static global::MonoJavaBridge.MethodId _getReplacement13311;
		protected abstract char[] getReplacement();
		internal static global::MonoJavaBridge.MethodId _ReplacementTransformationMethod13312;
		public ReplacementTransformationMethod()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.ReplacementTransformationMethod.staticClass, global::android.text.method.ReplacementTransformationMethod._ReplacementTransformationMethod13312);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.ReplacementTransformationMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/ReplacementTransformationMethod"));
			global::android.text.method.ReplacementTransformationMethod._onFocusChanged13308 = @__env.GetMethodIDNoThrow(global::android.text.method.ReplacementTransformationMethod.staticClass, "onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V");
			global::android.text.method.ReplacementTransformationMethod._getTransformation13309 = @__env.GetMethodIDNoThrow(global::android.text.method.ReplacementTransformationMethod.staticClass, "getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;");
			global::android.text.method.ReplacementTransformationMethod._getOriginal13310 = @__env.GetMethodIDNoThrow(global::android.text.method.ReplacementTransformationMethod.staticClass, "getOriginal", "()[C");
			global::android.text.method.ReplacementTransformationMethod._getReplacement13311 = @__env.GetMethodIDNoThrow(global::android.text.method.ReplacementTransformationMethod.staticClass, "getReplacement", "()[C");
			global::android.text.method.ReplacementTransformationMethod._ReplacementTransformationMethod13312 = @__env.GetMethodIDNoThrow(global::android.text.method.ReplacementTransformationMethod.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.method.ReplacementTransformationMethod))]
	public sealed partial class ReplacementTransformationMethod_ : android.text.method.ReplacementTransformationMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ReplacementTransformationMethod_()
		{
			InitJNI();
		}
		internal ReplacementTransformationMethod_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOriginal13313;
		protected override char[] getOriginal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.ReplacementTransformationMethod_._getOriginal13313)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.ReplacementTransformationMethod_.staticClass, global::android.text.method.ReplacementTransformationMethod_._getOriginal13313)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _getReplacement13314;
		protected override char[] getReplacement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.ReplacementTransformationMethod_._getReplacement13314)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.ReplacementTransformationMethod_.staticClass, global::android.text.method.ReplacementTransformationMethod_._getReplacement13314)) as char[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.ReplacementTransformationMethod_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/ReplacementTransformationMethod"));
			global::android.text.method.ReplacementTransformationMethod_._getOriginal13313 = @__env.GetMethodIDNoThrow(global::android.text.method.ReplacementTransformationMethod_.staticClass, "getOriginal", "()[C");
			global::android.text.method.ReplacementTransformationMethod_._getReplacement13314 = @__env.GetMethodIDNoThrow(global::android.text.method.ReplacementTransformationMethod_.staticClass, "getReplacement", "()[C");
		}
	}
}
