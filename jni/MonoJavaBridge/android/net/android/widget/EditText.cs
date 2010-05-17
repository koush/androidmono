namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class EditText : android.widget.TextView
	{ 
		internal new static global::java.lang.Class staticClass; 
		static EditText() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.EditText), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _setText9401; 
		public override void setText(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.EditText)) 
				@__env.CallVoidMethod(this, _setText9401, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.EditText.staticClass, _setText9401, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _selectAll9402; 
		public virtual void selectAll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.EditText)) 
				@__env.CallVoidMethod(this, _selectAll9402); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.EditText.staticClass, _selectAll9402); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText9403; 
		public virtual new android.text.Editable getText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.EditText)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, _getText9403)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.EditText.staticClass, _getText9403)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelection9404; 
		public virtual void setSelection(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.EditText)) 
				@__env.CallVoidMethod(this, _setSelection9404, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.EditText.staticClass, _setSelection9404, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelection9405; 
		public virtual void setSelection(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.EditText)) 
				@__env.CallVoidMethod(this, _setSelection9405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.EditText.staticClass, _setSelection9405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultEditable9406; 
		protected override bool getDefaultEditable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.EditText)) 
				return @__env.CallBooleanMethod(this, _getDefaultEditable9406); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.EditText.staticClass, _getDefaultEditable9406); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultMovementMethod9407; 
		protected override android.text.method.MovementMethod getDefaultMovementMethod() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.EditText)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallObjectMethodPtr(this, _getDefaultMovementMethod9407)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.EditText.staticClass, _getDefaultMovementMethod9407)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEllipsize9408; 
		public override void setEllipsize(android.text.TextUtils.TruncateAt arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.EditText)) 
				@__env.CallVoidMethod(this, _setEllipsize9408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.EditText.staticClass, _setEllipsize9408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extendSelection9409; 
		public virtual void extendSelection(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.EditText)) 
				@__env.CallVoidMethod(this, _extendSelection9409, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.EditText.staticClass, _extendSelection9409, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _EditText9410; 
		public EditText(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.EditText.staticClass, _EditText9410, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _EditText9411; 
		public EditText(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.EditText.staticClass, _EditText9411, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _EditText9412; 
		public EditText(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.EditText.staticClass, _EditText9412, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.EditText.staticClass = @__class; 
			global::android.widget.EditText._setText9401 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V"); 
			global::android.widget.EditText._selectAll9402 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "selectAll", "()V"); 
			global::android.widget.EditText._getText9403 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "getText", "()Landroid/text/Editable;"); 
			global::android.widget.EditText._setSelection9404 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "setSelection", "(I)V"); 
			global::android.widget.EditText._setSelection9405 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "setSelection", "(II)V"); 
			global::android.widget.EditText._getDefaultEditable9406 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "getDefaultEditable", "()Z"); 
			global::android.widget.EditText._getDefaultMovementMethod9407 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;"); 
			global::android.widget.EditText._setEllipsize9408 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V"); 
			global::android.widget.EditText._extendSelection9409 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "extendSelection", "(I)V"); 
			global::android.widget.EditText._EditText9410 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.EditText._EditText9411 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.EditText._EditText9412 = @__env.GetMethodID(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
