namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TwoLineListItem : android.widget.RelativeLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TwoLineListItem(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate18214;
		protected override void onFinishInflate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TwoLineListItem.staticClass, "onFinishInflate", "()V", ref global::android.widget.TwoLineListItem._onFinishInflate18214);
		}
		public new global::android.widget.TextView Text1
		{
			get
			{
				return getText1();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getText118215;
		public virtual global::android.widget.TextView getText1()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TwoLineListItem.staticClass, "getText1", "()Landroid/widget/TextView;", ref global::android.widget.TwoLineListItem._getText118215) as android.widget.TextView;
		}
		public new global::android.widget.TextView Text2
		{
			get
			{
				return getText2();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getText218216;
		public virtual global::android.widget.TextView getText2()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TwoLineListItem.staticClass, "getText2", "()Landroid/widget/TextView;", ref global::android.widget.TwoLineListItem._getText218216) as android.widget.TextView;
		}
		internal static global::MonoJavaBridge.MethodId _TwoLineListItem18217;
		public TwoLineListItem(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TwoLineListItem._TwoLineListItem18217.native == global::System.IntPtr.Zero)
				global::android.widget.TwoLineListItem._TwoLineListItem18217 = @__env.GetMethodIDNoThrow(global::android.widget.TwoLineListItem.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TwoLineListItem.staticClass, global::android.widget.TwoLineListItem._TwoLineListItem18217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TwoLineListItem18218;
		public TwoLineListItem(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TwoLineListItem._TwoLineListItem18218.native == global::System.IntPtr.Zero)
				global::android.widget.TwoLineListItem._TwoLineListItem18218 = @__env.GetMethodIDNoThrow(global::android.widget.TwoLineListItem.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TwoLineListItem.staticClass, global::android.widget.TwoLineListItem._TwoLineListItem18218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TwoLineListItem18219;
		public TwoLineListItem(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TwoLineListItem._TwoLineListItem18219.native == global::System.IntPtr.Zero)
				global::android.widget.TwoLineListItem._TwoLineListItem18219 = @__env.GetMethodIDNoThrow(global::android.widget.TwoLineListItem.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TwoLineListItem.staticClass, global::android.widget.TwoLineListItem._TwoLineListItem18219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static TwoLineListItem()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TwoLineListItem.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TwoLineListItem"));
		}
		internal static void InitJNI()
		{
		}
	}
}
