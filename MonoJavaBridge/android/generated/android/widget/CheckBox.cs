namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CheckBox : android.widget.CompoundButton
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CheckBox(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CheckBox16840;
		public CheckBox(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckBox._CheckBox16840.native == global::System.IntPtr.Zero)
				global::android.widget.CheckBox._CheckBox16840 = @__env.GetMethodIDNoThrow(global::android.widget.CheckBox.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckBox.staticClass, global::android.widget.CheckBox._CheckBox16840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CheckBox16841;
		public CheckBox(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckBox._CheckBox16841.native == global::System.IntPtr.Zero)
				global::android.widget.CheckBox._CheckBox16841 = @__env.GetMethodIDNoThrow(global::android.widget.CheckBox.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckBox.staticClass, global::android.widget.CheckBox._CheckBox16841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CheckBox16842;
		public CheckBox(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckBox._CheckBox16842.native == global::System.IntPtr.Zero)
				global::android.widget.CheckBox._CheckBox16842 = @__env.GetMethodIDNoThrow(global::android.widget.CheckBox.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckBox.staticClass, global::android.widget.CheckBox._CheckBox16842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static CheckBox()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CheckBox.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CheckBox"));
		}
		internal static void InitJNI()
		{
		}
	}
}
