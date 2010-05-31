namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface TextWatcher : NoCopySpan
	{ 
		void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3); 
		void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3); 
		void afterTextChanged(android.text.Editable arg0); 
	} 

	public partial class TextWatcher_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __TextWatcher.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __TextWatcher : java.lang.Object, TextWatcher
	{ 
		internal static global::java.lang.Class staticClass; 
		static __TextWatcher() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.__TextWatcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.__TextWatcher(@__env); 
			} 
		} 
		internal __TextWatcher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTextChanged7034; 
		 void android.text.TextWatcher.onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.text.__TextWatcher._onTextChanged7034, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__TextWatcher.staticClass, global::android.text.__TextWatcher._onTextChanged7034, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beforeTextChanged7035; 
		 void android.text.TextWatcher.beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.text.__TextWatcher._beforeTextChanged7035, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__TextWatcher.staticClass, global::android.text.__TextWatcher._beforeTextChanged7035, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _afterTextChanged7036; 
		 void android.text.TextWatcher.afterTextChanged(android.text.Editable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.text.__TextWatcher._afterTextChanged7036, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__TextWatcher.staticClass, global::android.text.__TextWatcher._afterTextChanged7036, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.__TextWatcher.staticClass = @__class; 
			global::android.text.__TextWatcher._onTextChanged7034 = @__env.GetMethodID(global::android.text.__TextWatcher.staticClass, "android.text.TextWatcher.onTextChanged", "(Ljava/lang/CharSequence;III)V"); 
			global::android.text.__TextWatcher._beforeTextChanged7035 = @__env.GetMethodID(global::android.text.__TextWatcher.staticClass, "android.text.TextWatcher.beforeTextChanged", "(Ljava/lang/CharSequence;III)V"); 
			global::android.text.__TextWatcher._afterTextChanged7036 = @__env.GetMethodID(global::android.text.__TextWatcher.staticClass, "android.text.TextWatcher.afterTextChanged", "(Landroid/text/Editable;)V"); 
		} 
	} 
} 
