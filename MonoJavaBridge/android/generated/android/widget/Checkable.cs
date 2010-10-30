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
	internal sealed partial class Checkable_ : java.lang.Object, Checkable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Checkable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toggle16843;
		void android.widget.Checkable.toggle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Checkable_._toggle16843.native == global::System.IntPtr.Zero)
				global::android.widget.Checkable_._toggle16843 = @__env.GetMethodIDNoThrow(global::android.widget.Checkable_.staticClass, "toggle", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Checkable_._toggle16843);
		}
		internal static global::MonoJavaBridge.MethodId _isChecked16844;
		bool android.widget.Checkable.isChecked()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Checkable_._isChecked16844.native == global::System.IntPtr.Zero)
				global::android.widget.Checkable_._isChecked16844 = @__env.GetMethodIDNoThrow(global::android.widget.Checkable_.staticClass, "isChecked", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Checkable_._isChecked16844);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked16845;
		void android.widget.Checkable.setChecked(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Checkable_._setChecked16845.native == global::System.IntPtr.Zero)
				global::android.widget.Checkable_._setChecked16845 = @__env.GetMethodIDNoThrow(global::android.widget.Checkable_.staticClass, "setChecked", "(Z)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Checkable_._setChecked16845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Checkable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Checkable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Checkable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
