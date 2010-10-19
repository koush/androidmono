namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EditText : android.widget.TextView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EditText()
		{
			InitJNI();
		}
		protected EditText(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setText11745;
		public override void setText(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.EditText._setText11745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.EditText.staticClass, global::android.widget.EditText._setText11745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setText(string arg0, android.widget.TextView.BufferType arg1)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _selectAll11746;
		public virtual void selectAll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.EditText._selectAll11746);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.EditText.staticClass, global::android.widget.EditText._selectAll11746);
		}
		public new global::android.text.Editable Text
		{
			get
			{
				return getText();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getText11747;
		public virtual global::android.text.Editable getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.EditText._getText11747)) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.EditText.staticClass, global::android.widget.EditText._getText11747)) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _setSelection11748;
		public virtual void setSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.EditText._setSelection11748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.EditText.staticClass, global::android.widget.EditText._setSelection11748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelection11749;
		public virtual void setSelection(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.EditText._setSelection11749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.EditText.staticClass, global::android.widget.EditText._setSelection11749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected new bool DefaultEditable
		{
			get
			{
				return getDefaultEditable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultEditable11750;
		protected override bool getDefaultEditable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.EditText._getDefaultEditable11750);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.EditText.staticClass, global::android.widget.EditText._getDefaultEditable11750);
		}
		protected new global::android.text.method.MovementMethod DefaultMovementMethod
		{
			get
			{
				return getDefaultMovementMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultMovementMethod11751;
		protected override global::android.text.method.MovementMethod getDefaultMovementMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.EditText._getDefaultMovementMethod11751)) as android.text.method.MovementMethod;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.EditText.staticClass, global::android.widget.EditText._getDefaultMovementMethod11751)) as android.text.method.MovementMethod;
		}
		internal static global::MonoJavaBridge.MethodId _setEllipsize11752;
		public override void setEllipsize(android.text.TextUtils.TruncateAt arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.EditText._setEllipsize11752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.EditText.staticClass, global::android.widget.EditText._setEllipsize11752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _extendSelection11753;
		public virtual void extendSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.EditText._extendSelection11753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.EditText.staticClass, global::android.widget.EditText._extendSelection11753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _EditText11754;
		public EditText(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.EditText.staticClass, global::android.widget.EditText._EditText11754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EditText11755;
		public EditText(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.EditText.staticClass, global::android.widget.EditText._EditText11755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EditText11756;
		public EditText(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.EditText.staticClass, global::android.widget.EditText._EditText11756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.EditText.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/EditText"));
			global::android.widget.EditText._setText11745 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V");
			global::android.widget.EditText._selectAll11746 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "selectAll", "()V");
			global::android.widget.EditText._getText11747 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "getText", "()Landroid/text/Editable;");
			global::android.widget.EditText._setSelection11748 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "setSelection", "(I)V");
			global::android.widget.EditText._setSelection11749 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "setSelection", "(II)V");
			global::android.widget.EditText._getDefaultEditable11750 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "getDefaultEditable", "()Z");
			global::android.widget.EditText._getDefaultMovementMethod11751 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;");
			global::android.widget.EditText._setEllipsize11752 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V");
			global::android.widget.EditText._extendSelection11753 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "extendSelection", "(I)V");
			global::android.widget.EditText._EditText11754 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.EditText._EditText11755 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.EditText._EditText11756 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
