namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface TransformationMethod 
	{ 
		void onFocusChanged(android.view.View arg0, java.lang.CharSequence arg1, bool arg2, int arg3, android.graphics.Rect arg4); 
		global::java.lang.CharSequence getTransformation(java.lang.CharSequence arg0, android.view.View arg1); 
	} 

	public partial class TransformationMethod_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __TransformationMethod.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __TransformationMethod : java.lang.Object, TransformationMethod
	{ 
		internal static global::java.lang.Class staticClass; 
		static __TransformationMethod() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.__TransformationMethod), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.method.__TransformationMethod(@__env); 
			} 
		} 
		internal __TransformationMethod(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged7275; 
		 void android.text.method.TransformationMethod.onFocusChanged(android.view.View arg0, java.lang.CharSequence arg1, bool arg2, int arg3, android.graphics.Rect arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.__TransformationMethod)) 
				@__env.CallVoidMethod(this, global::android.text.method.__TransformationMethod._onFocusChanged7275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.__TransformationMethod.staticClass, global::android.text.method.__TransformationMethod._onFocusChanged7275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransformation7276; 
		 global::java.lang.CharSequence android.text.method.TransformationMethod.getTransformation(java.lang.CharSequence arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.__TransformationMethod)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.method.__TransformationMethod._getTransformation7276, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.method.__TransformationMethod.staticClass, global::android.text.method.__TransformationMethod._getTransformation7276, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.__TransformationMethod.staticClass = @__class; 
			global::android.text.method.__TransformationMethod._onFocusChanged7275 = @__env.GetMethodID(global::android.text.method.__TransformationMethod.staticClass, "android.text.method.TransformationMethod.onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V"); 
			global::android.text.method.__TransformationMethod._getTransformation7276 = @__env.GetMethodID(global::android.text.method.__TransformationMethod.staticClass, "android.text.method.TransformationMethod.getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;"); 
		} 
	} 
} 
