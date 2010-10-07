namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ClipboardManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ClipboardManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.ClipboardManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.ClipboardManager(@__env);
			}
		}
		protected ClipboardManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _setText7353;
		public virtual void setText(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.ClipboardManager._setText7353, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.ClipboardManager.staticClass, global::android.text.ClipboardManager._setText7353, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getText7354;
		public virtual global::java.lang.CharSequence getText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.ClipboardManager._getText7354));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.ClipboardManager.staticClass, global::android.text.ClipboardManager._getText7354));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasText7355;
		public virtual bool hasText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.ClipboardManager._hasText7355);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.ClipboardManager.staticClass, global::android.text.ClipboardManager._hasText7355);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.ClipboardManager.staticClass = @__class;
			global::android.text.ClipboardManager._setText7353 = @__env.GetMethodID(global::android.text.ClipboardManager.staticClass, "setText", "(Ljava/lang/CharSequence;)V");
			global::android.text.ClipboardManager._getText7354 = @__env.GetMethodID(global::android.text.ClipboardManager.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.text.ClipboardManager._hasText7355 = @__env.GetMethodID(global::android.text.ClipboardManager.staticClass, "hasText", "()Z");
		}
	}
}
