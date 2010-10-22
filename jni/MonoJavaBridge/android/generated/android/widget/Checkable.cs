namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.Checkable_))]
	public partial interface Checkable  : global::MonoJavaBridge.IJavaObject 
	{
		void toggle();
		bool isChecked();
		void setChecked(bool arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Checkable))]
	public sealed partial class Checkable_ : java.lang.Object, Checkable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Checkable_()
		{
			InitJNI();
		}
		internal Checkable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toggle16749;
		 void android.widget.Checkable.toggle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Checkable_._toggle16749);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Checkable_.staticClass, global::android.widget.Checkable_._toggle16749);
		}
		internal static global::MonoJavaBridge.MethodId _isChecked16750;
		 bool android.widget.Checkable.isChecked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Checkable_._isChecked16750);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Checkable_.staticClass, global::android.widget.Checkable_._isChecked16750);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked16751;
		 void android.widget.Checkable.setChecked(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Checkable_._setChecked16751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Checkable_.staticClass, global::android.widget.Checkable_._setChecked16751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Checkable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Checkable"));
			global::android.widget.Checkable_._toggle16749 = @__env.GetMethodIDNoThrow(global::android.widget.Checkable_.staticClass, "toggle", "()V");
			global::android.widget.Checkable_._isChecked16750 = @__env.GetMethodIDNoThrow(global::android.widget.Checkable_.staticClass, "isChecked", "()Z");
			global::android.widget.Checkable_._setChecked16751 = @__env.GetMethodIDNoThrow(global::android.widget.Checkable_.staticClass, "setChecked", "(Z)V");
		}
	}
}
