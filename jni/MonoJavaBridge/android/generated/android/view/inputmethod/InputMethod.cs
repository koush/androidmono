namespace android.view.inputmethod
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface InputMethod 
	{
		void createSession(android.view.inputmethod.InputMethod_SessionCallback arg0);
		void setSessionEnabled(android.view.inputmethod.InputMethodSession arg0, bool arg1);
		void revokeSession(android.view.inputmethod.InputMethodSession arg0);
		void attachToken(android.os.IBinder arg0);
		void bindInput(android.view.inputmethod.InputBinding arg0);
		void unbindInput();
		void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
		void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
		void showSoftInput(int arg0, android.os.ResultReceiver arg1);
		void hideSoftInput(int arg0, android.os.ResultReceiver arg1);
	}

	public partial class InputMethod_
	{
		public static global::java.lang.Class _class
		{
			get { return __InputMethod.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __InputMethod : java.lang.Object, InputMethod
	{
		internal static global::java.lang.Class staticClass;
		static __InputMethod()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.inputmethod.__InputMethod), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.inputmethod.__InputMethod(@__env);
			}
		}
		internal __InputMethod(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _createSession9852;
		 void android.view.inputmethod.InputMethod.createSession(android.view.inputmethod.InputMethod_SessionCallback arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.__InputMethod._createSession9852, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.__InputMethod.staticClass, global::android.view.inputmethod.__InputMethod._createSession9852, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSessionEnabled9853;
		 void android.view.inputmethod.InputMethod.setSessionEnabled(android.view.inputmethod.InputMethodSession arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.__InputMethod._setSessionEnabled9853, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.__InputMethod.staticClass, global::android.view.inputmethod.__InputMethod._setSessionEnabled9853, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _revokeSession9854;
		 void android.view.inputmethod.InputMethod.revokeSession(android.view.inputmethod.InputMethodSession arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.__InputMethod._revokeSession9854, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.__InputMethod.staticClass, global::android.view.inputmethod.__InputMethod._revokeSession9854, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _attachToken9855;
		 void android.view.inputmethod.InputMethod.attachToken(android.os.IBinder arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.__InputMethod._attachToken9855, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.__InputMethod.staticClass, global::android.view.inputmethod.__InputMethod._attachToken9855, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindInput9856;
		 void android.view.inputmethod.InputMethod.bindInput(android.view.inputmethod.InputBinding arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.__InputMethod._bindInput9856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.__InputMethod.staticClass, global::android.view.inputmethod.__InputMethod._bindInput9856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unbindInput9857;
		 void android.view.inputmethod.InputMethod.unbindInput() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.__InputMethod._unbindInput9857);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.__InputMethod.staticClass, global::android.view.inputmethod.__InputMethod._unbindInput9857);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startInput9858;
		 void android.view.inputmethod.InputMethod.startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.__InputMethod._startInput9858, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.__InputMethod.staticClass, global::android.view.inputmethod.__InputMethod._startInput9858, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restartInput9859;
		 void android.view.inputmethod.InputMethod.restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.__InputMethod._restartInput9859, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.__InputMethod.staticClass, global::android.view.inputmethod.__InputMethod._restartInput9859, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showSoftInput9860;
		 void android.view.inputmethod.InputMethod.showSoftInput(int arg0, android.os.ResultReceiver arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.__InputMethod._showSoftInput9860, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.__InputMethod.staticClass, global::android.view.inputmethod.__InputMethod._showSoftInput9860, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hideSoftInput9861;
		 void android.view.inputmethod.InputMethod.hideSoftInput(int arg0, android.os.ResultReceiver arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.__InputMethod._hideSoftInput9861, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.__InputMethod.staticClass, global::android.view.inputmethod.__InputMethod._hideSoftInput9861, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.inputmethod.__InputMethod.staticClass = @__class;
			global::android.view.inputmethod.__InputMethod._createSession9852 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethod.staticClass, "android.view.inputmethod.InputMethod.createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V");
			global::android.view.inputmethod.__InputMethod._setSessionEnabled9853 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethod.staticClass, "android.view.inputmethod.InputMethod.setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V");
			global::android.view.inputmethod.__InputMethod._revokeSession9854 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethod.staticClass, "android.view.inputmethod.InputMethod.revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V");
			global::android.view.inputmethod.__InputMethod._attachToken9855 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethod.staticClass, "android.view.inputmethod.InputMethod.attachToken", "(Landroid/os/IBinder;)V");
			global::android.view.inputmethod.__InputMethod._bindInput9856 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethod.staticClass, "android.view.inputmethod.InputMethod.bindInput", "(Landroid/view/inputmethod/InputBinding;)V");
			global::android.view.inputmethod.__InputMethod._unbindInput9857 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethod.staticClass, "android.view.inputmethod.InputMethod.unbindInput", "()V");
			global::android.view.inputmethod.__InputMethod._startInput9858 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethod.staticClass, "android.view.inputmethod.InputMethod.startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
			global::android.view.inputmethod.__InputMethod._restartInput9859 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethod.staticClass, "android.view.inputmethod.InputMethod.restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
			global::android.view.inputmethod.__InputMethod._showSoftInput9860 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethod.staticClass, "android.view.inputmethod.InputMethod.showSoftInput", "(ILandroid/os/ResultReceiver;)V");
			global::android.view.inputmethod.__InputMethod._hideSoftInput9861 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethod.staticClass, "android.view.inputmethod.InputMethod.hideSoftInput", "(ILandroid/os/ResultReceiver;)V");
		}
	}
}
