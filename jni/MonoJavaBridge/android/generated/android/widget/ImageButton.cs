namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ImageButton : android.widget.ImageView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ImageButton()
		{
			InitJNI();
		}
		protected ImageButton(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onSetAlpha17243;
		protected override bool onSetAlpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ImageButton._onSetAlpha17243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ImageButton.staticClass, global::android.widget.ImageButton._onSetAlpha17243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ImageButton17244;
		public ImageButton(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageButton.staticClass, global::android.widget.ImageButton._ImageButton17244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageButton17245;
		public ImageButton(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageButton.staticClass, global::android.widget.ImageButton._ImageButton17245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageButton17246;
		public ImageButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageButton.staticClass, global::android.widget.ImageButton._ImageButton17246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ImageButton.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ImageButton"));
			global::android.widget.ImageButton._onSetAlpha17243 = @__env.GetMethodIDNoThrow(global::android.widget.ImageButton.staticClass, "onSetAlpha", "(I)Z");
			global::android.widget.ImageButton._ImageButton17244 = @__env.GetMethodIDNoThrow(global::android.widget.ImageButton.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ImageButton._ImageButton17245 = @__env.GetMethodIDNoThrow(global::android.widget.ImageButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ImageButton._ImageButton17246 = @__env.GetMethodIDNoThrow(global::android.widget.ImageButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
