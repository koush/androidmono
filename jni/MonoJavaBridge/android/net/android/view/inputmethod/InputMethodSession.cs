namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface InputMethodSession 
	{ 
		void dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2); 
		void dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2); 
		void finishInput(); 
		void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5); 
		void updateCursor(android.graphics.Rect arg0); 
		void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0); 
		void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1); 
		void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1); 
		void toggleSoftInput(int arg0, int arg1); 
	} 

	public partial class InputMethodSession_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __InputMethodSession.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __InputMethodSession : java.lang.Object, InputMethodSession
	{ 
		internal static global::java.lang.Class staticClass; 
		static __InputMethodSession() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.inputmethod.__InputMethodSession), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.inputmethod.__InputMethodSession(@__env); 
			} 
		} 
		internal __InputMethodSession(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent9198; 
		 void android.view.inputmethod.InputMethodSession.dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.__InputMethodSession)) 
				@__env.CallVoidMethod(this, _dispatchKeyEvent9198, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.__InputMethodSession.staticClass, _dispatchKeyEvent9198, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent9199; 
		 void android.view.inputmethod.InputMethodSession.dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.__InputMethodSession)) 
				@__env.CallVoidMethod(this, _dispatchTrackballEvent9199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.__InputMethodSession.staticClass, _dispatchTrackballEvent9199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finishInput9200; 
		 void android.view.inputmethod.InputMethodSession.finishInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.__InputMethodSession)) 
				@__env.CallVoidMethod(this, _finishInput9200); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.__InputMethodSession.staticClass, _finishInput9200); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateSelection9201; 
		 void android.view.inputmethod.InputMethodSession.updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.__InputMethodSession)) 
				@__env.CallVoidMethod(this, _updateSelection9201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.__InputMethodSession.staticClass, _updateSelection9201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateCursor9202; 
		 void android.view.inputmethod.InputMethodSession.updateCursor(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.__InputMethodSession)) 
				@__env.CallVoidMethod(this, _updateCursor9202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.__InputMethodSession.staticClass, _updateCursor9202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _displayCompletions9203; 
		 void android.view.inputmethod.InputMethodSession.displayCompletions(android.view.inputmethod.CompletionInfo[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.__InputMethodSession)) 
				@__env.CallVoidMethod(this, _displayCompletions9203, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.__InputMethodSession.staticClass, _displayCompletions9203, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateExtractedText9204; 
		 void android.view.inputmethod.InputMethodSession.updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.__InputMethodSession)) 
				@__env.CallVoidMethod(this, _updateExtractedText9204, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.__InputMethodSession.staticClass, _updateExtractedText9204, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _appPrivateCommand9205; 
		 void android.view.inputmethod.InputMethodSession.appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.__InputMethodSession)) 
				@__env.CallVoidMethod(this, _appPrivateCommand9205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.__InputMethodSession.staticClass, _appPrivateCommand9205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toggleSoftInput9206; 
		 void android.view.inputmethod.InputMethodSession.toggleSoftInput(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.__InputMethodSession)) 
				@__env.CallVoidMethod(this, _toggleSoftInput9206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.__InputMethodSession.staticClass, _toggleSoftInput9206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.inputmethod.__InputMethodSession.staticClass = @__class; 
			global::android.view.inputmethod.__InputMethodSession._dispatchKeyEvent9198 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethodSession.staticClass, "android.view.inputmethod.InputMethodSession.dispatchKeyEvent", "(ILandroid/view/KeyEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V"); 
			global::android.view.inputmethod.__InputMethodSession._dispatchTrackballEvent9199 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethodSession.staticClass, "android.view.inputmethod.InputMethodSession.dispatchTrackballEvent", "(ILandroid/view/MotionEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V"); 
			global::android.view.inputmethod.__InputMethodSession._finishInput9200 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethodSession.staticClass, "android.view.inputmethod.InputMethodSession.finishInput", "()V"); 
			global::android.view.inputmethod.__InputMethodSession._updateSelection9201 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethodSession.staticClass, "android.view.inputmethod.InputMethodSession.updateSelection", "(IIIIII)V"); 
			global::android.view.inputmethod.__InputMethodSession._updateCursor9202 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethodSession.staticClass, "android.view.inputmethod.InputMethodSession.updateCursor", "(Landroid/graphics/Rect;)V"); 
			global::android.view.inputmethod.__InputMethodSession._displayCompletions9203 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethodSession.staticClass, "android.view.inputmethod.InputMethodSession.displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V"); 
			global::android.view.inputmethod.__InputMethodSession._updateExtractedText9204 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethodSession.staticClass, "android.view.inputmethod.InputMethodSession.updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V"); 
			global::android.view.inputmethod.__InputMethodSession._appPrivateCommand9205 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethodSession.staticClass, "android.view.inputmethod.InputMethodSession.appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.view.inputmethod.__InputMethodSession._toggleSoftInput9206 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethodSession.staticClass, "android.view.inputmethod.InputMethodSession.toggleSoftInput", "(II)V"); 
		} 
	} 
} 
