namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EditText : android.widget.TextView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EditText(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void setText(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.EditText.staticClass, "setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V", ref global::android.widget.EditText._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setText(string arg0, android.widget.TextView.BufferType arg1)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void selectAll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.EditText.staticClass, "selectAll", "()V", ref global::android.widget.EditText._m1);
		}
		public new global::android.text.Editable Text
		{
			get
			{
				return getText();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.text.Editable getText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.widget.EditText.staticClass, "getText", "()Landroid/text/Editable;", ref global::android.widget.EditText._m2) as android.text.Editable;
		}
		public new int Selection
		{
			set
			{
				setSelection(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setSelection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.EditText.staticClass, "setSelection", "(I)V", ref global::android.widget.EditText._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setSelection(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.EditText.staticClass, "setSelection", "(II)V", ref global::android.widget.EditText._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected new bool DefaultEditable
		{
			get
			{
				return getDefaultEditable();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override bool getDefaultEditable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.EditText.staticClass, "getDefaultEditable", "()Z", ref global::android.widget.EditText._m5);
		}
		protected new global::android.text.method.MovementMethod DefaultMovementMethod
		{
			get
			{
				return getDefaultMovementMethod();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override global::android.text.method.MovementMethod getDefaultMovementMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.method.MovementMethod>(this, global::android.widget.EditText.staticClass, "getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;", ref global::android.widget.EditText._m6) as android.text.method.MovementMethod;
		}
		public new global::android.text.TextUtils.TruncateAt Ellipsize
		{
			set
			{
				setEllipsize(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void setEllipsize(android.text.TextUtils.TruncateAt arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.EditText.staticClass, "setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V", ref global::android.widget.EditText._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void extendSelection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.EditText.staticClass, "extendSelection", "(I)V", ref global::android.widget.EditText._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public EditText(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.EditText._m9.native == global::System.IntPtr.Zero)
				global::android.widget.EditText._m9 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.EditText.staticClass, global::android.widget.EditText._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public EditText(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.EditText._m10.native == global::System.IntPtr.Zero)
				global::android.widget.EditText._m10 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.EditText.staticClass, global::android.widget.EditText._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public EditText(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.EditText._m11.native == global::System.IntPtr.Zero)
				global::android.widget.EditText._m11 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.EditText.staticClass, global::android.widget.EditText._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static EditText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.EditText.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/EditText"));
		}
		internal static void InitJNI()
		{
		}
	}
}
