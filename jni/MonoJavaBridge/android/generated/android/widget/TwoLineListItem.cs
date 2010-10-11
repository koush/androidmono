namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TwoLineListItem : android.widget.RelativeLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TwoLineListItem()
		{
			InitJNI();
		}
		protected TwoLineListItem(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate12362;
		protected override void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TwoLineListItem._onFinishInflate12362);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TwoLineListItem.staticClass, global::android.widget.TwoLineListItem._onFinishInflate12362);
		}
		internal static global::MonoJavaBridge.MethodId _getText112363;
		public virtual global::android.widget.TextView getText1() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TwoLineListItem._getText112363)) as android.widget.TextView;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TwoLineListItem.staticClass, global::android.widget.TwoLineListItem._getText112363)) as android.widget.TextView;
		}
		internal static global::MonoJavaBridge.MethodId _getText212364;
		public virtual global::android.widget.TextView getText2() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TwoLineListItem._getText212364)) as android.widget.TextView;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TwoLineListItem.staticClass, global::android.widget.TwoLineListItem._getText212364)) as android.widget.TextView;
		}
		internal static global::MonoJavaBridge.MethodId _TwoLineListItem12365;
		public TwoLineListItem(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TwoLineListItem.staticClass, global::android.widget.TwoLineListItem._TwoLineListItem12365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TwoLineListItem12366;
		public TwoLineListItem(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TwoLineListItem.staticClass, global::android.widget.TwoLineListItem._TwoLineListItem12366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TwoLineListItem12367;
		public TwoLineListItem(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TwoLineListItem.staticClass, global::android.widget.TwoLineListItem._TwoLineListItem12367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TwoLineListItem.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TwoLineListItem"));
			global::android.widget.TwoLineListItem._onFinishInflate12362 = @__env.GetMethodIDNoThrow(global::android.widget.TwoLineListItem.staticClass, "onFinishInflate", "()V");
			global::android.widget.TwoLineListItem._getText112363 = @__env.GetMethodIDNoThrow(global::android.widget.TwoLineListItem.staticClass, "getText1", "()Landroid/widget/TextView;");
			global::android.widget.TwoLineListItem._getText212364 = @__env.GetMethodIDNoThrow(global::android.widget.TwoLineListItem.staticClass, "getText2", "()Landroid/widget/TextView;");
			global::android.widget.TwoLineListItem._TwoLineListItem12365 = @__env.GetMethodIDNoThrow(global::android.widget.TwoLineListItem.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TwoLineListItem._TwoLineListItem12366 = @__env.GetMethodIDNoThrow(global::android.widget.TwoLineListItem.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.TwoLineListItem._TwoLineListItem12367 = @__env.GetMethodIDNoThrow(global::android.widget.TwoLineListItem.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
