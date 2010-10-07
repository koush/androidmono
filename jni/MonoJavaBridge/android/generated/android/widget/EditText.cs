namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class EditText : android.widget.TextView
	{
		internal new static global::java.lang.Class staticClass;
		static EditText()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.EditText), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.EditText(@__env);
			}
		}
		protected EditText(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _setText10822;
		public override void setText(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.EditText._setText10822, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.EditText.staticClass, global::android.widget.EditText._setText10822, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		public void setText(string arg0, android.widget.TextView.BufferType arg1)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _selectAll10823;
		public virtual void selectAll() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.EditText._selectAll10823);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.EditText.staticClass, global::android.widget.EditText._selectAll10823);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getText10824;
		public virtual new global::android.text.Editable getText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.EditText._getText10824));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.EditText.staticClass, global::android.widget.EditText._getText10824));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection10825;
		public virtual void setSelection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.EditText._setSelection10825, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.EditText.staticClass, global::android.widget.EditText._setSelection10825, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection10826;
		public virtual void setSelection(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.EditText._setSelection10826, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.EditText.staticClass, global::android.widget.EditText._setSelection10826, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultEditable10827;
		protected override bool getDefaultEditable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.EditText._getDefaultEditable10827);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.EditText.staticClass, global::android.widget.EditText._getDefaultEditable10827);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultMovementMethod10828;
		protected override global::android.text.method.MovementMethod getDefaultMovementMethod() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.EditText._getDefaultMovementMethod10828));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.EditText.staticClass, global::android.widget.EditText._getDefaultMovementMethod10828));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEllipsize10829;
		public override void setEllipsize(android.text.TextUtils.TruncateAt arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.EditText._setEllipsize10829, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.EditText.staticClass, global::android.widget.EditText._setEllipsize10829, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendSelection10830;
		public virtual void extendSelection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.EditText._extendSelection10830, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.EditText.staticClass, global::android.widget.EditText._extendSelection10830, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _EditText10831;
		public EditText(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.EditText.staticClass, global::android.widget.EditText._EditText10831, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _EditText10832;
		public EditText(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.EditText.staticClass, global::android.widget.EditText._EditText10832, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _EditText10833;
		public EditText(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.EditText.staticClass, global::android.widget.EditText._EditText10833, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.EditText.staticClass = @__class;
			global::android.widget.EditText._setText10822 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V");
			global::android.widget.EditText._selectAll10823 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "selectAll", "()V");
			global::android.widget.EditText._getText10824 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "getText", "()Landroid/text/Editable;");
			global::android.widget.EditText._setSelection10825 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "setSelection", "(I)V");
			global::android.widget.EditText._setSelection10826 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "setSelection", "(II)V");
			global::android.widget.EditText._getDefaultEditable10827 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "getDefaultEditable", "()Z");
			global::android.widget.EditText._getDefaultMovementMethod10828 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;");
			global::android.widget.EditText._setEllipsize10829 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V");
			global::android.widget.EditText._extendSelection10830 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "extendSelection", "(I)V");
			global::android.widget.EditText._EditText10831 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.EditText._EditText10832 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.EditText._EditText10833 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
