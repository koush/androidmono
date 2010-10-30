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
		private static global::MonoJavaBridge.MethodId _m0;
		void android.widget.Checkable.toggle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Checkable_.staticClass, "toggle", "()V", ref global::android.widget.Checkable_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool android.widget.Checkable.isChecked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Checkable_.staticClass, "isChecked", "()Z", ref global::android.widget.Checkable_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void android.widget.Checkable.setChecked(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Checkable_.staticClass, "setChecked", "(Z)V", ref global::android.widget.Checkable_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
